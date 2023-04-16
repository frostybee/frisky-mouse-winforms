using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32CreateWindow.NetStandard;

namespace Win32CreateWindow
{
    internal class Program : NativeWindow
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*var layered = new LayeredWindow();
            layered.Show();
            Thread.Sleep(3124);
            layered.Move();
            Thread.Sleep(3124);
            layered.Hide();*/
            /*int s = SystemInformation.DoubleClickTime;
            Size ss = SystemInformation.DoubleClickSize;
            int now = System.Environment.TickCount;
            long noww = DateTime.UtcNow.Ticks;

            Console.WriteLine("Double clikc time "+ s);
            Console.WriteLine("Tick count " + now);
            Console.WriteLine("Tick count " + noww);
            Console.ReadKey(true);
            Console.WriteLine("Test");*/
        }
    }
}
