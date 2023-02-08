using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostybee.MouseDecorator.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawMouseHighlighter(this Graphics gr, HighlighterSettings circle)
        {
            // TODO: adjust the radius and settings
            // TODO: create a method that computes the required bounding rectangle. 
            // TODO: refactor this code. 
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
            int doubledRadius = circle.Radius * 2;
            // Apply the selected opacity on the color to be used in the _highlighterSettings. 

            Color selectedColor = Color.FromArgb(circle.Opacity, circle.FillColor);
            if (circle.IsFilled)
            {
                using (SolidBrush brush = new SolidBrush(selectedColor))
                {
                    // TODO: move the rectangle code to Drawing helper class. 
                    // make a method that creates a rectange.
                    gr.FillEllipse(brush, new Rectangle(
                        0,
                        0,
                        doubledRadius, doubledRadius
                        //circle.Radius,  circle.Radius 
                        ));
                }
            }
            else
            {
                // Draw just an outline --> empty circle.
                using (Pen pen = new Pen(selectedColor, circle.OutlineThickness))
                {
                    pen.DashStyle = circle.OutlineStyle;
                    gr.DrawEllipse(pen, new Rectangle(5, 5, doubledRadius - 5, doubledRadius - 5));
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
