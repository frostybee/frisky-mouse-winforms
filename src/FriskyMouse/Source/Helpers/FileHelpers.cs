#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.Helpers;

public static class FileHelpers
{
    public static string GetAbsolutePath()
    {
        return Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
    }

    public static string ExpandFolderVariables(string path, bool supportCustomSpecialFolders = false)
    {
        if (!string.IsNullOrEmpty(path))
        {
            try
            {
                foreach (Environment.SpecialFolder specialFolder in FMAppHelpers.GetEnums<Environment.SpecialFolder>())
                {
                    path = path.Replace($"%{specialFolder}%", Environment.GetFolderPath(specialFolder), StringComparison.OrdinalIgnoreCase);
                }

                path = Environment.ExpandEnvironmentVariables(path);
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
            }
        }

        return path;
    }

    public static void CreateDirectory(string directoryPath)
    {
        if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
        {
            try
            {
                Directory.CreateDirectory(directoryPath);
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
                /*MessageBox.Show(Resources.Helpers_CreateDirectoryIfNotExist_Create_failed_ + "\r\n\r\n" + e, "FriskyMouse- " + Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }
    }

    public static void CreateDirectoryFromFilePath(string filePath)
    {
        if (!string.IsNullOrEmpty(filePath))
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            CreateDirectory(directoryPath);
        }
    }
}