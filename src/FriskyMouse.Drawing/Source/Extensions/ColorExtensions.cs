#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Extensions
{
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
}
