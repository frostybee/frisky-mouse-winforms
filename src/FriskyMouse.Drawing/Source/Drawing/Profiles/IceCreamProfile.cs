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

using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents a single expanding ripple.
    /// </summary>
    internal class IceCreamProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        private SolidBrush _innerBrush;
        private SolidBrush _outerBrush;
        private int _baseRadius = 4;
        public IceCreamProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _outlinePen = new Pen(Color.Crimson.WithOpacity(200), 4);

            //-- 1) Add the middle ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius + 3,
                    RadiusMultiplier = 3,
                    FillBrush = _outerBrush,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(80), 8),
                    IsFilled = false,
                    IsStyleable = true,
                });            
            //-- 2) Add the outline ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius + 3),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius + 1,
                    RadiusMultiplier = 3,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(130), 8),
                    IsFilled = false,
                    IsStyleable = true,
                });
            //-- 3) Inner ripple that must drawn last.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius + 6),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius,
                    RadiusMultiplier = 2,
                    FillBrush = _innerBrush,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(100), 8),
                    IsFilled = false,
                    IsStyleable = true,
                });
        }
    }
}

