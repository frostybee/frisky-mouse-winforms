#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Settings;
using FriskyMouse.NativeApi;
using FriskyMouse.UI;

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
        try
        {            
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {

#if PORTABLE
                IsPortable = true;                
                BuildInfo = "Portable";
#elif MICROSOFTSTORE
            BuildInfo = "Microsoft Store";
#elif SELFCONTAINED
            IsPortable = true;
            BuildInfo = "Self contained";
#endif
                //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                SettingsManager.LoadSettings();
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
                // TODO: add DPI awareness. @see: main project.                     
                //Application.Run(new Form1());
                Application.Run(new MainForm());

                _mutex.ReleaseMutex();
            }
            else
            {
                // Send a message to the application's main window so that it gets shown to the user. 
                NativeMethods.SendMessage((IntPtr)SpecialWindowHandles.HWND_BROADCAST, WM_SHOW_MAIN_WINDOW, IntPtr.Zero, IntPtr.Zero);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
    {
        SettingsManager.SaveSettings();
        Exception e = (Exception)args.ExceptionObject;
        MessageBox.Show("Something went wrong: " + e.Message);
    }
}