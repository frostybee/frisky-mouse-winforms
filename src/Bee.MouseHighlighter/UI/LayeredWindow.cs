using Bee.GlobalHooks.NativeApi;

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinApiTypes = Bee.GlobalHooks.NativeApi;
namespace Bee.MouseDecorator.UI
{
    internal class LayeredWindow : NativeWindow, IDisposable
    {
        #region Constants
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_HIDE = 0;
        private const int ULW_ALPHA = 2;
        private const byte AC_SRC_OVER = 0x00;
        private const byte AC_SRC_ALPHA = 0x01; 
        #endregion

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
            TopCoordinate = 300;
            LeftCoordinate = 300;
            // Specify the form as the parent.
            //cp.Parent = parent.Handle;                        
            cp.ExStyle = Convert.ToInt32(ExtendedWinStyles.WS_CUSTOM_TRASPARENT_WINDOW);

            // Create the actual window
            this.CreateHandle(cp);
        }        

        public void Move(int x, int y)
        {
            NativeMethods.MoveWindow(Handle, x, y, Width, Height, false);
        }

        public void Hide()
        {
            //CreateHandle(new CreateParams());
            NativeMethods.ShowWindow(this.Handle, SW_HIDE);
        }
        public void Show()
        {
            //User32.SetForegroundWindow(Handle);
            //User32.BringWindowToTop(Handle);
            //BringWindowToTop
            //CreateHandle(new CreateParams());
            // Sets the specified window's show state.
            NativeMethods.ShowWindow(this.Handle, SW_SHOWNOACTIVATE);
        }
        // Listen to when the handle changes to keep the variable in sync
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void OnHandleChange()
        {
            handle = (int)this.Handle;
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
        public void SetBitmap(Bitmap newBitmap, byte opacity)
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

                WinApiTypes.Size newSize = new WinApiTypes.Size(newBitmap.Width, newBitmap.Height);
                WinApiTypes.POINT sourceLocation = new WinApiTypes.POINT(0, 0);
                WinApiTypes.POINT newLocation = new WinApiTypes.POINT(this.LeftCoordinate - newBitmap.Width / 2, this.TopCoordinate - newBitmap.Height / 2);

                // Set up the blend function.
                WinApiTypes.BLENDFUNCTION pBlend = default(WinApiTypes.BLENDFUNCTION);
                pBlend.BlendOp = AC_SRC_OVER;
                pBlend.BlendFlags = 0;
                pBlend.SourceConstantAlpha = opacity;
                pBlend.AlphaFormat = AC_SRC_ALPHA;
                NativeMethods.UpdateLayeredWindow(
                    this.Handle,         // Handle to the layered window
                    screenDc,            // Handle to the screen DC
                    ref newLocation,     // New screen position of the layered window
                    ref newSize,         // New size of the layered window
                    memoryDc,            // Handle to the layered window surface DC
                    ref sourceLocation,  // Location of the layer in the DC
                    0,                   // Color key of the layered window
                    ref pBlend,          // Transparency of the layered window
                    ULW_ALPHA // Use blend as the blend function
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

        /// <summary>
        /// The y coordinate
        /// </summary>
        public int TopCoordinate { get; set; }
        /// <summary>
        /// The x coordinate
        /// </summary>
        public int LeftCoordinate { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}

