using FriskyMouse.Core;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace FriskyMouse.MouseDecorator.Helpers
{
    internal class DrawingHelper
    {
        public static Bitmap DrawEllipseBitmap(HighlighterInfo settings)
        {
            //TODO: clean this messy code.
            int radius = settings.Radius;
            //int outline = (!settings.IsFilled ? settings.OutlineThickness +15: 5);
            settings.OutlineThickness = 1;
            int outline = 1;
            //Bitmap memoryBitmap = new Bitmap(radius *2 +5, radius*2+5, PixelFormat.Format32bppArgb);
            Bitmap memoryBitmap = new Bitmap(radius * 2 + outline, radius * 2 + outline, PixelFormat.Format32bppArgb);

            //Bitmap memoryBitmap = new Bitmap(200, 200, PixelFormat.Format32bppArgb);            
            using (Graphics graphics = Graphics.FromImage(memoryBitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                //graphics.DrawSpotlight(settings, new Rectangle(0,0, settings.Radius *2, settings.Radius *2));
                graphics.DrawSpotlight(settings);
                /*using (Pen pen = new Pen(settings.FillColor, settings.OutlineThickness))
                {
                    if (settings.IsFilled)
                    {
                        // Draw a filled ellipse
                        using (SolidBrush brush = new SolidBrush(settings.FillColor))
                        {
                            graphics.FillEllipse(brush, 0, 0, settings.Radius * 2, settings.Radius * 2);
                        }
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, 2, 2, radius * 2, radius * 2);
                    }
                }*/
            }
            return memoryBitmap;
        }
        private static void FillDrawing(Graphics graphics, Color color, int size)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillEllipse(brush, 0, 0, size * 2, size * 2);
            }
        }
    }

}
