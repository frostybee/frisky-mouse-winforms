using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseDecoratror.Core
{
    internal static class GraphicsExtensions
    {
        public static void DrawHighlighterPreview(this Graphics gr, CursorHighlighter circle)
        {
            // TODO: adjust the radius and settings
            // TODO: create a method that computes the required bounding rectangle. 
            // TODO: refactor this code. 
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            // Apply the selected opacity on the color to be used in the highlighter. 
            Color selectedColor = Color.FromArgb(circle.Opacity, circle.FillColor);
            if (circle.IsFilled)
            {
                using (SolidBrush brush = new SolidBrush(selectedColor))
                {
                    // TODO: move the rectangle code to Drawing helper class. 
                    // make a method that creates a rectange.
                    gr.FillEllipse(brush, new Rectangle(
                        circle.CenterX - circle.Radius,
                        circle.CenterY - circle.Radius,
                        //circle.Radius *2, circle.Radius *2
                        circle.Radius,  circle.Radius 
                        ));
                }
            }
            else
            {
                using (Pen pen = new Pen(selectedColor, circle.OutlineWidth))
                {
                    pen.DashStyle = circle.OutlineStyle;
                    gr.DrawEllipse(pen, new Rectangle(20, 20, circle.Radius, circle.Radius));
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
