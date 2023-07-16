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

using FriskyMouse.NativeApi;
using System.Drawing.Imaging;
using NativeStructs = FriskyMouse.NativeApi;

namespace FriskyMouse.UI;

/// <summary>
/// Represents a lightweight, click-through window onto which 
/// the mouse spotlight and other click indicators are rendered. 
/// </summary>
internal class LayeredWindow : NativeWindow, IDisposable
{
    // Handle of the main window.
    private int handle;
    private bool isDisposed;

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
    public LayeredWindow()
    {
        // TODO: fix scaling issue see winforms settings.
        CreateParams cp = new CreateParams();
        // 
        Height = 200;
        Width = 200;
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
    internal void Move()
    {
        NativeMethods.MoveWindow(Handle, PositionX, PositionY, Width, Height, false);
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
        if (Handle != IntPtr.Zero)
        {
            NativeMethods.ShowWindow(Handle, NativeConstants.SW_SHOWNOACTIVATE);
        }
    }
    internal void SetTopMost()
    {
        if (Handle != IntPtr.Zero)
        {
            SetWindowPosition(PositionX, PositionY);
        }
    }

    private void SetWindowPosition(int x, int y)
    {
        NativeMethods.SetWindowPos(Handle, (int)SpecialWindowHandles.HWND_TOPMOST, x, y, Width, Height, SetWindowPosFlags.SWP_NOACTIVATE);
    }

    public bool IsWindowTopMost()
    {
        int exStyle = (int)NativeMethods.GetWindowLongPtr(Handle, NativeConstants.GWL_EXSTYLE);
        return (exStyle & NativeConstants.WS_EX_TOPMOST) == NativeConstants.WS_EX_TOPMOST;
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
            pBlend.SourceConstantAlpha = 255;
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
}


