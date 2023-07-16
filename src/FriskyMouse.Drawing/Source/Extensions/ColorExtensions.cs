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

namespace FriskyMouse.Drawing.Extensions;

internal static class ColorExtensions
{
    public static Color ReduceOpacity(this Color color, int opacity)
    {
        return Color.FromArgb(255 - Math.Clamp(opacity,1, 255), color);
    }
    public static Color WithOpacity(this Color color, int opacity)
    {
        return Color.FromArgb(Math.Clamp(opacity, 1, 255), color);
    }       
}
