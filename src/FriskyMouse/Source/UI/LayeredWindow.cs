using FriskyMouse.NativeApi;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NativeStructs = FriskyMouse.NativeApi;

namespace FriskyMouse.UI
{
    /// <summary>
    /// Represents a lightweight window used for creating a layered, transparent window.
    /// It helps with drawing the mouse spotlight and other drawings for the sake of mouse behavior decoration such as right/left clicks,etc. 
    /// </summary>
    internal class LayeredWindow : NativeWindow, IDisposable
    {
        // Handle of the main window.
        private int handle;
        private bool isDisposed;

        public LayeredWindow()
        {            
            // TODO: fix scaling issue see winforms settings.
            CreateParams cp = new CreateParams();
            // 
            Height = 500;
            Width = 500;
            // Set the position on the form
            cp.X = 100;
            cp.Y = 100;
            cp.Height = Height;
            cp.Width = Width;
            PositionY = 300;
            PositionX = 300;
            cp.Style = NativeConstants.WS_POPUP;
            // Specify the form as the parent.
            //cp.Parent = parent.Handle;                        
            cp.ExStyle = (int)WindowStyles.WS_CUSTOM_LAYERED_WINDOW;

            // Create the actual window
            this.CreateHandle(cp);
            Hide();
        }
        internal void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
            Move();
        }
        /// <summary>
        /// Moves the layered window to the specified location.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        internal void Move()
        {
            NativeMethods.MoveWindow(Handle, PositionX, PositionY, Width, Height, false);
            // FIXME: Somehow setting the TOPMOST doesn't seem to work when clicking on slider| 
            // Should be done upon detecting a mouse click if the highlighter is enabled.
            //NativeMethods.SetWindowPos(Handle, NativeMethods.HWND_TOPMOST, 0, 0, 0, 0, NativeMethods.SWP_NOMOVE | NativeMethods.SWP_NOSIZE);
        }
        /// <summary>
        /// Hides the current instance of this layered window. 
        /// It should be called upon finishing decorating mouse clicks.
        /// </summary>
        internal void Hide()
        {
            if (Handle != IntPtr.Zero)
            {
                NativeMethods.ShowWindow(Handle, NativeConstants.SW_HIDE);
            }
        }
        /// <summary>
        /// Shows the current instance of this layered window. 
        /// </summary>
        internal void Show()
        {
            //User32.SetForegroundWindow(Handle);
            //User32.BringWindowToTop(Handle);
            //BringWindowToTop
            //CreateHandle(new CreateParams());
            // Sets the specified window's show state.
            if (Handle != IntPtr.Zero)
            {
                // TODO: set the initial position of the layered window.
                //POINT point = GetCursorPosition();
                //SetWindowPosition(point.X, point.Y);
                NativeMethods.ShowWindow(Handle, NativeConstants.SW_SHOWNOACTIVATE);                
            }
        }
        internal void SetTopMost()
        {
            // FIXME: this should be called in a delayed manner. 
            // Upon detecting a mouse click, around 500 ms should be elapsed before calling this method.

            Debug.WriteLine("Setting top most window....");
            if (Handle != IntPtr.Zero)
            {
                 SetWindowPosition(PositionX, PositionY);
                //NativeMethods.SetWindowPos(Handle, (IntPtr)SpecialWindowHandles.HWND_TOPMOST, position.X, position.Y, Config.Size.Width, Config.Size.Height,SetWindowPosFlags.SWP_NOACTIVATE);
                //NativeMethods.SetWindowPos(Handle, NativeMethods.HWND_TOPMOST, x, y, Width, Height, NativeMethods.SWP_NOMOVE | NativeMethods.SWP_NOSIZE);
                //NativeMethods.SetWindowPos(Handle, (int)SpecialWindowHandles.HWND_TOPMOST, x, y, Width, Height, SetWindowPosFlags.SWP_NOACTIVATE);
                //NativeConstants.SW_SHOWNOACTIVATE
            }
        }
        // TODO: move to a helper class.
        private void SetWindowPosition(int x, int y)
        {
            NativeMethods.SetWindowPos(Handle, (int)SpecialWindowHandles.HWND_TOPMOST, x, y, Width, Height, SetWindowPosFlags.SWP_NOACTIVATE);
        }
        internal POINT GetCursorPosition()
        {
            if (NativeMethods.GetCursorPos(out POINT point))
            {
                return point;
            }

            return POINT.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newBitmap"></param>
        /// <param name="opacity">
        /// Specifies an alpha transparency value to be used on the entire source 
        /// bitmap. The SourceConstantAlpha value is combined with any per-pixel 
        /// alpha values in the source bitmap. The value ranges from 0 to 255. If 
        /// you set SourceConstantAlpha to 0, it is assumed that your image is 
        /// transparent. When you only want to use per-pixel alpha values, set 
        /// the SourceConstantAlpha value to 255 (opaque).
        /// </param>
        /// <exception cref="ApplicationException"></exception>
        internal void SetBitmap(Bitmap newBitmap, byte opacity)
        {
            // Does this bitmap contain an alpha channel?
            if (newBitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                throw new ApplicationException("The bitmap must be 32ppp with alpha-channel.");
            }
            // Get device contexts
            IntPtr screenDc = NativeMethods.GetDC(IntPtr.Zero);
            IntPtr memoryDc = NativeMethods.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr hOldBitmap = IntPtr.Zero;
            try
            {
                // Get handle to the new bitmap and select it into the current 
                // device context.
                hBitmap = newBitmap.GetHbitmap(Color.FromArgb(0));
                hOldBitmap = NativeMethods.SelectObject(memoryDc, hBitmap);

                NativeStructs.Size newSize = new NativeStructs.Size(newBitmap.Width, newBitmap.Height);
                NativeStructs.POINT sourceLocation = new NativeStructs.POINT(0, 0);
                NativeStructs.POINT newLocation = new NativeStructs.POINT(this.PositionX - newBitmap.Width / 2, this.PositionY - newBitmap.Height / 2);

                // Set up the blend function.
                NativeStructs.BLENDFUNCTION pBlend = default(NativeStructs.BLENDFUNCTION);
                pBlend.BlendOp = NativeConstants.AC_SRC_OVER;
                pBlend.BlendFlags = 0;
                pBlend.SourceConstantAlpha = opacity;
                pBlend.AlphaFormat = NativeConstants.AC_SRC_ALPHA;
                NativeMethods.UpdateLayeredWindow(
                    this.Handle,         // Handle to the layered window
                    screenDc,            // Handle to the screen DC
                    ref newLocation,     // New screen position of the layered window
                    ref newSize,         // New size of the layered window
                    memoryDc,            // Handle to the layered window surface DC
                    ref sourceLocation,  // Location of the layer in the DC
                    0,                   // Color key of the layered window
                    ref pBlend,          // Transparency of the layered window
                    NativeConstants.ULW_ALPHA // Use blend as the blend function
                  );
            }
            finally
            {
                NativeMethods.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    NativeMethods.SelectObject(memoryDc, hOldBitmap);
                    NativeMethods.DeleteObject(hBitmap);
                }
                NativeMethods.DeleteDC(memoryDc);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null                
                ReleaseHandle();
                isDisposed = true;
            }
        }
        // Listen to when the handle changes to keep the variable in sync
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void OnHandleChange()
        {
            handle = (int)this.Handle;
        }

        ~LayeredWindow()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }        

        #region Properties
        /// <summary>
        /// The y coordinate
        /// </summary>
        public int PositionY { get; set; }
        /// <summary>
        /// The x coordinate
        /// </summary>
        public int PositionX { get; set; }
        public int Height { get; set; }
        public int Width { get; set; } 
        #endregion
    }
}

