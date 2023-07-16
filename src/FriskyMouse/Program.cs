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

using FriskyMouse.Settings;
using FriskyMouse.NativeApi;
using FriskyMouse.UI;
using FriskyMouse.Helpers;

namespace FriskyMouse;

internal static class Program
{
    /// <summary>
    /// A named system-wide mutex used to ensure that only one instance of this application runs at once. 
    /// </summary>
    private static string _mutexName = "FriskybeesAreTheBests";
    private static readonly Mutex _mutex = new Mutex(true, _mutexName);
    public static readonly uint WM_SHOW_MAIN_WINDOW = NativeMethods.RegisterWindowMessage("WM_SHOW_MAIN_WINDOW");
    public static bool IsPortable { get; private set; } = false;
    public static string BuildInfo { get; private set; } = "Release";
    public const string ApplicationName = "FriskyMouse";
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        if (_mutex.WaitOne(TimeSpan.Zero, true))
        {
#if DEBUG
     IsPortable = true;
     BuildInfo = "Debug";
#elif PORTABLE
                IsPortable = true;                
                BuildInfo = "Portable";
#elif MICROSOFTSTORE
            BuildInfo = "Microsoft Store";
#elif SELFCONTAINED
            IsPortable = true;
            BuildInfo = "Self contained";
#endif
#if !DEBUG
            // Add the event handler for handling UI thread exceptions to the event
            Application.ThreadException += Application_ThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif
            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            SettingsManager.LoadSettings();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);            
            Application.Run(new MainForm());
            _mutex.ReleaseMutex();
        }
        else
        {
            // Send a message to the application's main window so that it gets shown to the user. 
            NativeMethods.SendMessage((IntPtr)SpecialWindowHandles.HWND_BROADCAST, WM_SHOW_MAIN_WINDOW, IntPtr.Zero, IntPtr.Zero);
        }
    }
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        OnError(e.Exception);
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        OnError((Exception)e.ExceptionObject);
    }

    private static void OnError(Exception e)
    {
        using (ErrorForm errorForm = new ErrorForm(e.Message, $"{e}\r\n\r\n{ApplicationName}"))
        {
            errorForm.ShowDialog();
        }
        SettingsManager.SaveSettings();
    }
}