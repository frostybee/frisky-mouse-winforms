using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;
using MaterialSkin;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;


namespace FriskyMouse.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawHighlighter(this Graphics graphics, Rectangle rect, HighlighterOptions options)
        {
            graphics.SetAntiAliasing();

            // Apply the selected opacity on the color to be used in the _settings. 
            Color selectedColor = Color.FromArgb(options.Opacity, options.FillColor);
            if (options.IsFilled)
            {
                using SolidBrush brush = new SolidBrush(selectedColor);
                graphics.FillEllipse(brush, rect);
                if (options.IsOutlined)
                {
                    // Add an outline to the spotlight if enabled.
                    graphics.DrawOutline(options);
                }
            }
            else
            {
                graphics.DrawOutline(options);
            }
            if (options.HasShadow)
            {
                graphics.DrawRoundShadow(options);
            }
        }

        public static void DrawOutline(this Graphics graphics, HighlighterOptions options)
        {
            Rectangle outlineRect = DrawingHelper.CreateRectangle(options.Width, options.Height, options.Radius + 1);
            //using Pen pen = new Pen(Color.Red, options.OutlineWidth);
            using Pen pen = new Pen(options.OutlineColor, options.OutlineWidth);
            pen.DashStyle = options.OutlineStyle;
            graphics.DrawEllipse(pen, outlineRect);
        }
        public static void DrawRoundShadow(this Graphics g, HighlighterOptions options)
        {
            int radius = options.Radius + (options.IsOutlined ? options.OutlineWidth + 2 : 4);
            Rectangle shadowRect = DrawingHelper.CreateRectangle(options.Width, options.Height, radius);
            Color color = Color.FromArgb(Math.Min(Math.Max(1, 70), 255), options.OutlineColor);
            using Pen pen = new Pen(color, options.ShadowWidth + 4);
            g.DrawEllipse(pen, shadowRect);
        }
        public static void SetAntiAliasing(this Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
        }
    }
}
