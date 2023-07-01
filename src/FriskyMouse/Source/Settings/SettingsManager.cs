#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Helpers;
using System.Text.Json;

namespace FriskyMouse.Settings
{
    internal static class SettingsManager
    {
        private static string SettingsFileName = "settings.json";        
        private static Mutex _jsonMutex = new Mutex();
        public static SettingsWrapper Settings { get; private set; } = new SettingsWrapper();        
        private static readonly string PortablePersonalFolder = FileHelpers.GetAbsolutePath();
        private static readonly string DefaultPersonalFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Program.ApplicationName);
        private static string SettingsFolder
        {
            get
            {
                return DefaultPersonalFolder;
            }
        }

        private static string ApplicationSettingsFilePath
        {
            get
            {
                // TODO: check if it's portable or not.
                if (Program.IsPortable)
                {
                    return Path.Combine(PortablePersonalFolder, SettingsFileName);
                };
                return Path.Combine(SettingsFolder, SettingsFileName);
            }
        }
        public static void SaveSettings()
        {
            try
            {
                _jsonMutex.WaitOne();
                string filePath = ApplicationSettingsFilePath;
                if (!string.IsNullOrEmpty(filePath))
                {
                    LoadDefaultSettings();
                    Settings.ApplicationSettings.ApplicationName = Program.ApplicationName;
                    Settings.ApplicationSettings.Version = AppHelpers.GetApplicationVersion();
                    // Create the directory that will hold the settings file if it doesn't exist.
                    FileHelpers.CreateDirectoryFromFilePath(filePath);
                    FileStream createStream = File.Create(filePath);
                    JsonSerializer.SerializeAsync(createStream, Settings, GetJsonSerializerOptions());                    
                    createStream.DisposeAsync();                    
                    //TODO: verify if JSON file is not corrupted.
                }
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
                //OnSettingsSaveFailed(e);
            }
            finally
            {
                _jsonMutex.ReleaseMutex();
            }
        }

        public static void LoadSettings()
        {
            string settingFilePath = ApplicationSettingsFilePath;
            try
            {
                if (File.Exists(settingFilePath))
                {
                    using FileStream openStream = File.OpenRead(settingFilePath);                    
                    if (openStream.CanRead)
                    {
                        Settings = JsonSerializer.Deserialize<SettingsWrapper>(openStream, GetJsonSerializerOptions());
                        //TODO: verify if JSON file is not corrupted.
                    }
                }
            }
            catch (Exception)
            {
                // Failed to load the settings... Load the default ones.                
            }
        }

        private static void LoadDefaultSettings()
        {
            Settings ??= new SettingsWrapper();
        }
        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new ColorJsonConverter() }
            };
            return options;
        }
    }
}
