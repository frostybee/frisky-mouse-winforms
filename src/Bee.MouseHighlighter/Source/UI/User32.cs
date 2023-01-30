using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bee.GlobalHooks
{
    class User32
    {
        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool AllowSetForegroundWindow(uint dwProcessId);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool BringWindowToTop(IntPtr hWnd);
    }

}
