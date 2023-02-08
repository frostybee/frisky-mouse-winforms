using Frostybee.MouseDecorator.Core;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Frostybee.MouseDecorator.Helpers
{
    internal class DrawingHelper
    {
        public static Bitmap DrawEllipseBitmap(HighlighterSettings settings)
        {
            int size = settings.Radius;
            //Bitmap memoryBitmap = new Bitmap(size *2 +5, size*2+5, PixelFormat.Format32bppArgb);
            Bitmap memoryBitmap = new Bitmap(size * 2 + 5, size * 2 + 5 , PixelFormat.Format32bppArgb);

            //Bitmap memoryBitmap = new Bitmap(200, 200, PixelFormat.Format32bppArgb);            
            using (Graphics graphics = Graphics.FromImage(memoryBitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.DrawMouseHighlighter(settings);
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
                        graphics.DrawEllipse(pen, 2, 2, size * 2, size * 2);
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
