#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples;

/// <summary>
/// Represents a single expanding ripple.
/// </summary>
internal class SquaredPulseProfile : BaseRippleProfile
{
    private Pen _outlinePen;
    private SolidBrush _innerBrush;
    private SolidBrush _outerBrush;

    public SquaredPulseProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _innerBrush = new SolidBrush(Color.DarkBlue);
        _outerBrush = new SolidBrush(Color.Crimson);

        _outlinePen = new Pen(Color.DeepPink, 4);
        // 1) Make the outer most ripple.            
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius+5),
                ShapeType = ShapeType.Rectangle,
                InitialRadius = BaseRadius+5,
                IsFade = true,
                RadiusMultiplier = 2,
                FillBrush = _outerBrush,
                OutlinePen = _outlinePen,
                IsFilled = false,
                IsStyleable = true
            });
        //-- 2) Inner ripple that must drawn last.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = false,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 7),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 10,
                IsFade  = false,
                RadiusMultiplier = 2,
                FillBrush = _innerBrush,
                OutlinePen = _outlinePen,
                IsFilled = true,
            });
    }        
}
