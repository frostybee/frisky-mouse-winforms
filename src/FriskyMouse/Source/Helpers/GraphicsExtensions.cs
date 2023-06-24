using FriskyMouse.Drawing.Helpers;


namespace FriskyMouse.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawHighlighter(this Graphics graphics, Rectangle rect, HighlighterOptions options)
        {
            graphics.SetAntiAliasing();

            if (options.IsFilled)
            {
                // Apply the selected opacity on the color to be used in the _settings. 
                Color selectedColor = Color.FromArgb(options.Opacity, options.FillColor);
                using SolidBrush brush = new SolidBrush(selectedColor);
                graphics.FillEllipse(brush, rect);

            }
            else
            {
                graphics.DrawOutline(options);
            }
            if (options.HasShadow)
            {
                graphics.DrawRoundShadow(options);                
                /*GraphicsPath gp =  DrawingHelper.CreateCircle(200, 200, options.Radius + options.OutlineWidth+4);
                DrawingHelper.DrawShadow(graphics, gp, 15, options.ShadowDepth, options.ShadowColor);                
                gp.Dispose();*/
            }
            if (options.IsOutlined & options.IsFilled)
            {
                // Add an outline to the spotlight if enabled.
                graphics.DrawOutline(options);
            }
        }

        public static void DrawOutline(this Graphics graphics, HighlighterOptions options)
        {
            Rectangle outlineRect = DrawingHelper.CreateRectangle(options.Width, options.Height, options.Radius + 2);
            //using Pen pen = new Pen(Color.Red, options.OutlineWidth);
            using Pen pen = new Pen(options.OutlineColor, options.OutlineWidth);
            pen.DashStyle = options.OutlineStyle;
            graphics.DrawEllipse(pen, outlineRect);
        }

        public static void DrawRoundShadow(this Graphics graphics, HighlighterOptions options)
        {
            int radius = options.Radius +
                (options.IsOutlined ? options.OutlineWidth + 4: options.ShadowDepth - options.OutlineWidth
                //: (options.HasShadow ? options.ShadowDepth : 0)
                );
            Rectangle shadowRect = DrawingHelper.CreateRectangle(options.Width, options.Height, radius);
            Color color = Color.FromArgb(options.ShadowOpacity, options.ShadowColor);
            using Pen pen = new Pen(color, options.ShadowDepth);
            graphics.DrawEllipse(pen, shadowRect);
        }
        public static void SetAntiAliasing(this Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
        }
    }
}
