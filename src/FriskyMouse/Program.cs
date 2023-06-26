using FriskyMouse.Settings;
using FriskyMouse.NativeApi;
using FriskyMouse.UI;

namespace FriskyMouse
{
    internal static class Program
    {
        /// <summary>
        /// A named system-wide mutex used to ensure that only one instance of this application runs at once. 
        /// </summary>
        private static string _mutexName = "FriskybeesAreTheBest";
        private static readonly Mutex _mutex = new Mutex(true, _mutexName);
        public static readonly uint WM_SHOW_MAIN_WINDOW = NativeMethods.RegisterWindowMessage("WM_SHOW_MAIN_WINDOW");
        public static bool IsPortable { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                    IsPortable = true;
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                // Send a message to the application's main window so that it gets shown to the user. 
                NativeMethods.SendMessage((IntPtr)SpecialWindowHandles.HWND_BROADCAST, WM_SHOW_MAIN_WINDOW, IntPtr.Zero, IntPtr.Zero);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show("Something went wrong: "+e.Message); 
        }
    }
}