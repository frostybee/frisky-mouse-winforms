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

internal class SpotlightProfile : BaseRippleProfile
{        
    private SolidBrush _innerBrush;
    public SpotlightProfile()
    {
        CreateProfileEntries();
    }
    private void CreateProfileEntries()
    {
        _innerBrush = new SolidBrush(Color.Crimson);            
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = false,
                Bounds = DrawingHelper.CreateRectangle(Width, Height, 15),
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 15,
                RadiusMultiplier = 3,
                FillBrush = _innerBrush,
                IsFilled = true,
                IsFade = true,
                IsStyleable = true
            });
    }
}
