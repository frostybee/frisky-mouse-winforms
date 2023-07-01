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

namespace FriskyMouse.Drawing.Ripples;

internal class DiamondProfile : BaseRippleProfile
{
    private Pen _outlinePen;
    int _baseRadius = 10; // Needs to be parametrized.

    public DiamondProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _outlinePen = new Pen(Color.DarkBlue, 4);
        // 1) Make the outer most ripple.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,                    
                ShapeType = ShapeType.Polygon,
                InitialRadius = _baseRadius,
                RadiusMultiplier = 2,
                OutlinePen = _outlinePen,
                IsFilled = false,
                PolygonType = PolygonType.Diamond,
                IsStyleable = true
            });            
    }
}
