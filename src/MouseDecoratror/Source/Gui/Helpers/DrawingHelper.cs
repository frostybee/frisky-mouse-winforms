using Bee.MouseDecorator.Core;
using MouseDecoratror.Core;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bee.MouseDecorator.Helpers
{
    internal class DrawingHelper
    {
        public static Bitmap DrawEllipseBitmap(HighlighterSettings bitmapInfo)
        {
            int size = bitmapInfo.Radius;
            //Bitmap memoryBitmap = new Bitmap(size *2 +5, size*2+5, PixelFormat.Format32bppArgb);
            Bitmap memoryBitmap = new Bitmap(size * 2 + 5, size * 2 + 5);

            //Bitmap memoryBitmap = new Bitmap(200, 200, PixelFormat.Format32bppArgb);            
            using (Graphics graphics = Graphics.FromImage(memoryBitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                using (Pen pen = new Pen(bitmapInfo.FillColor, bitmapInfo.OutlineThickness))
                {
                    if (bitmapInfo.IsFilled)
                    {
                        // Draw a filled ellipse
                        using (SolidBrush brush = new SolidBrush(bitmapInfo.FillColor))
                        {
                            graphics.FillEllipse(brush, 0, 0, bitmapInfo.Radius * 2, bitmapInfo.Radius * 2);
                        }
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, 2, 2, size * 2, size * 2);
                    }
                }
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
