using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32CreateWindow.NetStandard
{
    internal class LayeredWindow : NativeWindow
    {
        // Constant values were found in the "windows.h" header file.
        private const int WS_CHILD = 0x40000000,
                          WS_VISIBLE = 0x10000000,
                          WM_ACTIVATEAPP = 0x001C;
        public const int WS_EX_LAYERED = 0x80000;

        /// <summary>
        /// The window should not be painted until siblings beneath the window
        /// (that were created by the same thread) have been painted.
        /// </summary>
        public const int WS_EX_TRANSPARENT = 0x20;
        /// <summary>
        /// The window should be placed above all non-topmost windows and should stay above them, 
        /// even when the window is deactivated
        /// </summary>
        public const int WS_EX_TOPMOST = 0x00000008;
        public const int WS_EX_NOACTIVATE = 0x08000000;
        public const int WS_EX_APPWINDOW = 0x00040000;
        public const int WS_EX_COMPOSITED = 0x02000000;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_HIDE = 0;
        


        private int windowHandle;

        public LayeredWindow()
        {

            CreateParams cp = new CreateParams();

            // Fill in the CreateParams details.
            //cp.Caption = "Click here";
            //cp.ClassName = "Button";

            // Set the position on the form
            cp.X = 100;
            cp.Y = 100;
            cp.Height = 300;
            cp.Width = 300;

            // Specify the form as the parent.
            //cp.Parent = parent.Handle;

            // Create as a child of the specified parent
            cp.Style = WS_VISIBLE;
            //cp.ExStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT;
            
            // Create the actual window
            this.CreateHandle(cp);
        }
        [DllImport("User32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, short cmdShow);

        // MoveWindow moves a window or changes its size based on a window handle.
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public void Move()
        {
            MoveWindow(Handle, 333, 344, 23, 34, true);
        }

        public void Hide()
        {
            //CreateHandle(new CreateParams());
            ShowWindow(this.Handle, SW_HIDE);
        }
        public void Show()
        {
            //CreateHandle(new CreateParams());
            ShowWindow(this.Handle, SW_SHOWNOACTIVATE);
        }
        // Listen to when the handle changes to keep the variable in sync
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void OnHandleChange()
        {
            windowHandle = (int)this.Handle;
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            // Listen for messages that are sent to the button window. Some messages are sent
            // to the parent window instead of the button's window.

            switch (m.Msg)
            {
                case WM_ACTIVATEAPP:
                    // Do something here in response to messages
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
