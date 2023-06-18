using System;
using System.Drawing;

namespace FriskyMouse.Drawing.Extensions
{
    internal static class ColorExtensions
    {
        public static Color ReduceOpacity(this Color inColor, int opacity)
        {
            return Color.FromArgb(255 - Math.Min(Math.Max(0,opacity), 255), inColor);
        }
        public static Color WithOpacity(this Color inColor, int opacity)
        {
            return Color.FromArgb(Math.Min(Math.Max(1, opacity), 255), inColor);
        }       
    }
}
