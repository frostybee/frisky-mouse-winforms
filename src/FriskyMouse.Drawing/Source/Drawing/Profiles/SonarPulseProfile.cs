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
/// Represents a expanding sonar pulse-like ripple.
/// </summary>
public class SonarPulseProfile : BaseRippleProfile
{
    private SolidBrush _innerBrush;
    private Pen _outerPen;
    private Pen _middlePen;
    public SonarPulseProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _innerBrush = new SolidBrush(Color.Crimson);
        _outerPen = new Pen(Color.DeepPink, 4);
        _middlePen = new Pen(Color.Yellow, 3);

        // 1) Make the outer ripple.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 15),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = BaseRadius,
                RadiusMultiplier = 3,                    
                OutlinePen = _outerPen,
                IsFilled = false,
                IsStyleable = true
            });
        // 2) Make the middle ripple. 
        AddRipple(   
            new RippleEntry()
            {
                IsExpandable = false,
                IsFade = false,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 10),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 10,
                RadiusMultiplier = 2,
                OutlinePen = _middlePen,
                IsFilled = false,
            });
        // 3) Make the most inner ripple. It must drawn last.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = false,
                IsFade = false,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 9),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 9,
                RadiusMultiplier = 2,
                FillBrush = _innerBrush,
                IsFilled = true,
            });
    }
}
