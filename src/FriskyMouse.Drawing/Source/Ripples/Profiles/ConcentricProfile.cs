﻿#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using System.Drawing.Drawing2D;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples;

internal class ConcentricProfile : BaseRippleProfile
{
    private SolidBrush _brushInnerRipple;
    private Pen _penOutline;
    private Pen _innerPen;        

    int _baseRadius = 40; // Needs to be parametrized.
    public ConcentricProfile()
    {
        CreateProfileEntries();
    }

    private void CreateProfileEntries()
    {
        _brushInnerRipple = new SolidBrush(Color.Yellow);
        _penOutline = new Pen(Color.Crimson, 4);
        _innerPen = new Pen(Color.SteelBlue, 3)
        {
            DashStyle = DashStyle.Dash
        };
        
        int width = 200;
        int height = 200;
    
        // 1) Make the outer most ripple.
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = true,
                Bounds = DrawingHelper.CreateRectangle(width, height, _baseRadius * 2),
                FillBrush = _brushInnerRipple,
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 10,
                RadiusMultiplier = 2.5f,
                OutlinePen = _penOutline,
                IsFilled = false,
                IsStyleable = true
            });
        //-- 2) Make ripples that will be rendered between the inner most and outer most ripples.
        int radius = 6;            
        for (int i = 0; i < 3; i++)
        {
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(width, height, radius),
                    FillBrush = _brushInnerRipple,
                    ShapeType = ShapeType.Ellipse,
                    OutlinePen = _innerPen,
                    RadiusMultiplier = 2,
                    InitialRadius = radius,
                    IsFade = false,
                    IsFilled = false,
                });
            radius += 2;
        }
        // Make the core (most inner ripple).            
        AddRipple(
            new RippleEntry()
            {
                IsExpandable = false,
                IsFade = false,
                Bounds = DrawingHelper.CreateRectangle(width, height, 7),
                FillBrush = _brushInnerRipple,
                ShapeType = ShapeType.Ellipse,
                InitialRadius = 7,
                IsFilled = true,
                IsStyleable = false
            }); ;
    }        
}
