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
