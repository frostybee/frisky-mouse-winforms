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

namespace FriskyMouse.Drawing.Ripples;

internal class HexagonProfile : BaseRippleProfile
{
    private Pen _outlinePen;        
    public HexagonProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _outlinePen = new Pen(Color.Crimson, 4);
        // 1) Make the outer most ripple.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,                    
                ShapeType = ShapeType.Polygon,
                InitialRadius = 10,
                RadiusMultiplier = 2,
                OutlinePen = _outlinePen,
                IsFilled = false,
                PolygonType = PolygonType.Hexagon,
                IsStyleable = true,                    
            });
    }
}
