using FriskyMouse.Helpers;
using System.Text.Json;
using FriskyMouse.Core;

namespace FriskyMouse.Settings
{
    internal static class SettingsManager
    {
        private static string SettingsFileName = "settings.json";
        private const string ApplicationName = "FriskyMouse";
        // Used to synchronize access to the settings.json file
        private static Mutex _jsonMutex = new Mutex();
        public static ApplicationSettings? Settings { get; private set; }
        // I guess this is the path of the folder holding the executable of this application. 
        private static readonly string PortablePersonalFolder = FileHelpers.GetAbsolutePath();
        private static readonly string DefaultPersonalFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ApplicationName);
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
                    Settings.ApplicationName = ApplicationName;
                    // Create the directory that will hold the settings file if it doesn't exist.
                    FileHelpers.CreateDirectoryFromFilePath(filePath);
                    using FileStream createStream = File.Create(filePath);
                    JsonSerializer.SerializeAsync(createStream, Settings, GetJsonSerializerOptions());
                    createStream.DisposeAsync();
                    Console.WriteLine(File.ReadAllText(filePath));
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
                if (!File.Exists(settingFilePath))
                {
                    // Reading the settings file has failed. Fallback/load the default settings.
                    LoadDefaultSettings();
                }
                else
                {
                    using FileStream openStream = File.OpenRead(settingFilePath);
                    //TODO: check if can read from stream. 
                    if (openStream.CanRead)
                    {
                        Settings = JsonSerializer.Deserialize<ApplicationSettings>(openStream, GetJsonSerializerOptions());
                        //TODO: verify if JSON file is not corrupted.
                    }
                }
            }
            catch (Exception)
            {
                // Failed to load the settings... Load the default ones.
                LoadDefaultSettings();
            }
        }

        private static void LoadDefaultSettings()
        {
            Settings ??= new ApplicationSettings();
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
