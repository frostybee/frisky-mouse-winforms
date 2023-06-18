using FriskyMouse.Drawing.Extensions;

namespace FriskyMouse.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawSpotlight(this Graphics graphics, Rectangle rect, HighlighterOptions spotlightModel)
        {
            graphics.SetAntiAliasing();
            int doubledRadius = spotlightModel.Radius * 2;

            // Apply the selected opacity on the color to be used in the _settings. 
            Color selectedColor = Color.FromArgb(spotlightModel.Opacity, spotlightModel.FillColor);
            if (spotlightModel.IsFilled)
            {
                using (SolidBrush brush = new SolidBrush(selectedColor))
                {
                    // TODO: move the rectangle code to Drawing helper class. 
                    // make a method that creates a rectangle.
                    //graphics.FillEllipse(brush, new Rectangle(0, 0, doubledRadius, doubledRadius));
                    graphics.FillEllipse(brush, rect);
                    /*//DrawHelper.DrawRoundShadow(graphics, rect);                    
                    using (Pen pen = new Pen(Color.FromArgb(200, Color.Blue), 6))
                    {
                        graphics.DrawEllipse(pen, rect);
                    }*/
                    //graphics.FillEllipse(brush, DrawingHelper.CreateRectangle(200, 200, spotlightModel.Radius));
                }
            }
            else
            {
                // Draw just an outline --> empty spotlightModel.
                using (Pen pen = new Pen(selectedColor, spotlightModel.OutlineThickness))
                {
                    pen.DashStyle = spotlightModel.OutlineStyle;
                    graphics.DrawEllipse(pen, rect);
                }
            }
        }


        public static void DrawCircle(this Graphics g, Pen pen,
                                  float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
        public static void FillCircle(this Graphics g, Brush brush,
                                  float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
    }
}
