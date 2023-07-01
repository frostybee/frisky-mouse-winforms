#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Drawing.Helpers;
using FriskyMouse.Helpers;
using FriskyMouse.NativeApi;
using FriskyMouse.UI;
using FriskyMouse.Extensions;
using FriskyMouse.Settings;

namespace FriskyMouse.Core;

internal class HighlighterController : IDisposable
{
    /// <summary>
    /// The bitmap on which the mouse highlighter is drawn.
    /// </summary>
    private Bitmap? _spotlightBitmap;
    /// <summary>
    /// The transparent, click-through window used 
    /// to show the mouse highlighter. 
    /// </summary>
    private LayeredWindow _highlighterWindow;
    private bool _disposed = false;
    private readonly HighlighterOptions _options;
    private int _width = 0;
    private int _height = 0;

    internal HighlighterController(HighlighterOptions options)
    {
        _highlighterWindow = new LayeredWindow();
        _options = options;
    }

    internal void SetHighlighterBitmap(HighlighterOptions highlighterInfo)
    {
        // Clean up any previously generated bitmap.
        _spotlightBitmap?.Dispose();
        _spotlightBitmap = DrawingHelper.CreateBitmap(200, 200, Color.Transparent);
        Graphics graphics = Graphics.FromImage(_spotlightBitmap);
        graphics.ClearCanvas();
        Rectangle rect = DrawingHelper.CreateRectangle(200, 200, highlighterInfo.Radius);
        graphics.DrawHighlighter(rect, highlighterInfo);
        _width = _spotlightBitmap.Width;
        _height = _spotlightBitmap.Height;
        _highlighterWindow.SetBitmap(_spotlightBitmap, highlighterInfo.Opacity);
        // Set the highlighter's initial position after launching the application or
        // applying new settings. 
        MoveSpotlight(AppHelpers.GetCursorPosition());
        _highlighterWindow.Show();
        graphics?.Dispose();
    }

    /// <summary>
    /// Moves the highlighter to the specified coordinates.
    /// </summary>
    /// <param name="inPoint">A point containing the current X and Y coordinates of the mouse cursor.</param>
    internal void MoveSpotlight(POINT inPoint)
    {
        if (_options.Enabled)
        {
            if (_spotlightBitmap != null)
            {
                SetLayeredWindowCoordinates(inPoint);
                _highlighterWindow.Move();
            }
        }
    }
    /// <summary>
    /// Brings the highlighter to the top just in case it got hidden by another application's context/popup menu.
    /// </summary>
    /// <param name="inPoint"></param>
    internal void BringToFront()
    {
        if (_options.Enabled)
        {
            // Adjust the coordinates of the layered window based on the spotlight's bitmap size.                
            SetLayeredWindowCoordinates(AppHelpers.GetCursorPosition());
            _highlighterWindow.SetTopMost();
        }
    }
    /// <summary>
    /// Repositions the layered window where the cursor is currently pointing on the screen.
    /// </summary>
    /// <param name="point">A point containing the X and Y coordinates of the mouse cursor. </param>
    private void SetLayeredWindowCoordinates(POINT point)
    {
        _highlighterWindow.PositionX = point.X - (_width / 2);
        _highlighterWindow.PositionY = point.Y - (_height / 2);
    }
    internal void SetInitialPosition()
    {
        POINT coordinates = AppHelpers.GetCursorPosition();
        if (coordinates != POINT.Empty)
        {
            SetLayeredWindowCoordinates(coordinates);
        }
    }
    internal void HideSpotlight()
    {
        _highlighterWindow?.Hide();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Clean up resources.
                _spotlightBitmap?.Dispose();
                _spotlightBitmap = null;
                _highlighterWindow?.Dispose();
                _highlighterWindow = null;

            }
            _disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}