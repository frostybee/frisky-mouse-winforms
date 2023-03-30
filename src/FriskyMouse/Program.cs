using Frostybee.GlobalHooks.NativeApi;
using Frostybee.MouseDecorator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frostybee.MouseDecorator
{
    internal static class Program
    {
        private static string _mutexName = "FriskybeesAreTheBest";
        private static Mutex _mutex = new Mutex(true, _mutexName);
        public const int HWND_BROADCAST = 0xffff;
        public static readonly uint WM_SHOW_MAIN_WINDOW = NativeMethods.RegisterWindowMessage("WM_SHOW_MAIN_WINDOW");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    // TODO: add DPI awareness. @see: main project. 
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());                    
                    _mutex.ReleaseMutex();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                NativeMethods.SendMessage((IntPtr)HWND_BROADCAST, WM_SHOW_MAIN_WINDOW, IntPtr.Zero, IntPtr.Zero);
            }            
        }
    }
}
