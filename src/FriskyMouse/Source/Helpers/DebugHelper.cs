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

using System.Diagnostics;

namespace FriskyMouse.Helpers;

public static class DebugHelper
{
    public static Logger Logger { get; private set; }

    public static void Init(string logFilePath)
    {
        Logger = new Logger(logFilePath);
    }

    public static void WriteLine(string message = "")
    {
        if (Logger != null)
        {
            Logger.WriteLine(message);
        }
        else
        {
            Debug.WriteLine(message);
        }
    }

    public static void WriteLine(string format, params object[] args)
    {
        WriteLine(string.Format(format, args));
    }

    public static void WriteException(string exception, string message = "Exception")
    {
        if (Logger != null)
        {
            Logger.WriteException(exception, message);
        }
        else
        {
            Debug.WriteLine(exception);
        }
    }

    public static void WriteException(Exception exception, string message = "Exception")
    {
        WriteException(exception.ToString(), message);
    }
}