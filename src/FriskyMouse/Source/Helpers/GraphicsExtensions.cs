using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawHighlighter(this Graphics graphics, Rectangle rect, HighlighterOptions options)
        {
            graphics.SetAntiAliasing();
            int doubledRadius = options.Radius * 2;

            // Apply the selected opacity on the color to be used in the _settings. 
            Color selectedColor = Color.FromArgb(options.Opacity, options.FillColor);
            if (options.IsFilled)
            {
                Rectangle outlineRect = DrawingHelper.CreateRectangle(200, 200, options.Radius + options.OutlineWidth-2);
                using SolidBrush brush = new SolidBrush(selectedColor);
                graphics.FillEllipse(brush, rect);
                // Draw just an outline --> empty options.
                //using Pen pen = new Pen(Color.Red, options.OutlineWidth);
                using Pen pen = new Pen(options.OutlineColor, options.OutlineWidth);
                pen.DashStyle = options.OutlineStyle;
                graphics.DrawEllipse(pen, outlineRect);
            }
            else
            {
                // Draw just an outline --> empty options.
                using Pen pen = new Pen(selectedColor, options.OutlineWidth);
                pen.DashStyle = options.OutlineStyle;
                graphics.DrawEllipse(pen, rect);
            }
        }
    }
}
