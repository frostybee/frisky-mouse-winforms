using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriskyMouse.MouseDecorator.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawSpotlight(this Graphics gr, HighlighterSettings spotlightModel)
        {
            // TODO: adjust the radius and settings
            // TODO: create a method that computes the required bounding rectangle. 
            // TODO: refactor this code. 
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
            int doubledRadius = spotlightModel.Radius * 2;

            // Apply the selected opacity on the color to be used in the _highlighterModel. 
            Color selectedColor = Color.FromArgb(spotlightModel.Opacity, spotlightModel.FillColor);
            if (spotlightModel.IsFilled)
            {
                using (SolidBrush brush = new SolidBrush(selectedColor))
                {
                    // TODO: move the rectangle code to Drawing helper class. 
                    // make a method that creates a rectangle.
                    //gr.FillEllipse(brush, new Rectangle(0, 0, doubledRadius, doubledRadius));
                    gr.FillEllipse(brush, spotlightModel.GetRectangle());
                }
            }
            else
            {
                // Draw just an outline --> empty spotlightModel.
                using (Pen pen = new Pen(selectedColor, spotlightModel.OutlineThickness))
                {
                    pen.DashStyle = spotlightModel.OutlineStyle;                    
                    gr.DrawEllipse(pen, spotlightModel.GetRectangle());
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
