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
/// Represents a filled, sonar pulse-like expanding ripple.
/// </summary>
public class FilledSonarPulseProfile : BaseRippleProfile
{
    private SolidBrush _innerBrush;
    private SolidBrush _outerBrush;
    private Pen _middlePen;
    public FilledSonarPulseProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _innerBrush = new SolidBrush(Color.DeepPink);
        _outerBrush = new SolidBrush(Color.DarkGreen);
        _middlePen = new Pen(Color.White, 3);

        // 1) Make the outer ripple.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 15),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = BaseRadius,
                RadiusMultiplier = 3,
                FillBrush = _outerBrush,
                IsFilled = true,
                IsStyleable = true
            });
        // 2) Make the middle ripple. 
        AddRipple(   
            new RippleEntry()
            {
                IsExpandable = false,
                IsFade = false,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 9),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 9,
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
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 8),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 8,
                RadiusMultiplier = 2,
                FillBrush = _innerBrush,
                IsFilled = true,
            });
    }
}
