using Bee.GlobalHooks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApiTypes = Bee.GlobalHooks;
namespace Bee.MouseHighlighter.UI
{
    internal abstract class LayeredForm : Form
    {
        // Constant values were found in the "windows.h" header file.
        private const int WS_EX_TOPMOST = 0x00000008,
                          WS_VISIBLE = 0x10000000,
                          WM_ACTIVATEAPP = 0x001C;

        public LayeredForm(Form parent)
        {
            base.FormBorderStyle = FormBorderStyle.None;
            base.TopMost = true;
            base.TopLevel = true;
            base.BringToFront();
            base.Focus();
            base.ShowInTaskbar = false;
            base.ControlBox = false;
            AllowDrop = false;            
        }
        


       // public virtual void SetBitmap(Bitmap bitmap, byte opacity) { }


        /// <summary>
        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/winmsg/window-features"/>
        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-updatelayeredwindow"/>
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="opacity"></param>
        public void SetBitmap(Bitmap bitmap, byte opacity)
        {
            if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                throw new ApplicationException("The bitmap must be 32ppp with alpha-channel.");
            }
            IntPtr dC = NativeMethods.GetDC(IntPtr.Zero);
            IntPtr compatibleDc = NativeMethods.CreateCompatibleDC(dC);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr hSelectedDc = IntPtr.Zero;
            try
            {
                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                hSelectedDc = NativeMethods.SelectObject(compatibleDc, hBitmap);
                WinApiTypes.Size psize = new WinApiTypes.Size(bitmap.Width, bitmap.Height);
                WinApiTypes.Point pprSrc = new WinApiTypes.Point(0, 0);
                WinApiTypes.Point pptDst = new WinApiTypes.Point(this.Left, this.Top);
                WinApiTypes.BLENDFUNCTION pblend = default(WinApiTypes.BLENDFUNCTION);
                pblend.BlendOp = 0;
                pblend.BlendFlags = 0;
                pblend.SourceConstantAlpha = opacity;
                pblend.AlphaFormat = 1;
                NativeMethods.UpdateLayeredWindow(this.Handle, dC, ref pptDst, ref psize, compatibleDc, ref pprSrc, 0, ref pblend, 2);
                //NativeWin32Methods.SetWindowLong(base.Handle, -20, (int)NativeWin32Methods.GetWindowLong(base.Handle, -20) | 0x20);
                // https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles
                //NativeWin32Methods.SetWindowLong(this.Handle, -20, (long)NativeWin32Methods.GetWindowLong(this.Handle, -20) | 32|0x80000000 | 0x00000000);
                NativeMethods.SetWindowLong(this.Handle, -20, (int)NativeMethods.GetWindowLong(this.Handle, -20) | 32);
            }
            finally
            {
                NativeMethods.ReleaseDC(IntPtr.Zero, dC);
                if (hBitmap != IntPtr.Zero)
                {
                    NativeMethods.SelectObject(compatibleDc, hSelectedDc);
                    NativeMethods.DeleteObject(hBitmap);
                }
                NativeMethods.DeleteDC(compatibleDc);
            }
        }

        /// <summary>
        /// Configures the layered window.
        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles"/>
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                // Extend the CreateParams property of the Button class.
                CreateParams cp = base.CreateParams;
                // Update the button Style.
                //cp.Style |= 0x00000040; // BS_ICON value
                cp.ExStyle |= 524288;
                return cp;
            }
        }
    }
}
