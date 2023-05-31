using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace FriskyMouse.HelpersLib.Helpers
{
    public class DrawingHelper
    {
        public static Bitmap CreateBitmap(int width, int height, Color inColor)
        {
            if (width > 0 && height > 0)
            {
                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);                
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.Clear(inColor);
                }
                return bmp;
            }
            return null;
        }

        /// <summary>
        /// Creates a bounding rectangle for a ripple drawing.
        /// </summary>
        /// <param name="rippleRadius"></param>
        /// <returns></returns>
        public static Rectangle CreateRectangle(int width, int height, int radius)
        {
            return new Rectangle(width / 2 - radius, height / 2 - radius, radius * 2, radius * 2);
        }
        internal static PointF[] CreateStarShape(int width, int radius)
        {
            double middleX = width / 2;
            double middleY = width / 2;
            double min = 0.05f;
            double half = radius;
            middleX = middleX - half;
            middleY = middleY - half;
            //TODO: put this in a helper class. Needs to be adjustable.
            // Create an array of points.
            PointF[] points =
                     {
                 new Point(Convert.ToInt32(middleX + half * (0.5 + min)), Convert.ToInt32(middleY + half * (0.84 + min))),
                 new Point(Convert.ToInt32(middleX + half * (1.5f + min)), Convert.ToInt32(middleY + half * (0.84f + min))),
                 new Point(Convert.ToInt32(middleX + half * (0.68f + min)), Convert.ToInt32(middleY + half * (1.45f + min))),
                 new Point(Convert.ToInt32(middleX + half * (1.0f + min)), Convert.ToInt32(middleY + half * (0.5f + min))),
                 new Point(Convert.ToInt32(middleX + half * (1.32f + min)), Convert.ToInt32(middleY + half * (1.45f + min))),
                 new Point(Convert.ToInt32(middleX + half * (0.5f + min)), Convert.ToInt32(middleY + half * (0.84f + min))),
             };
            return points;
        }

        internal static PointF[] CreateHexagon(int x, int y, int radius)
        {
            //Get the middle of the panel            
            PointF[] shapes = new PointF[6];
            //Create 6 points
            for (int i = 0; i < 6; i++)
            {  //- TODO: put this in a method. We need to create the shapes once and update the radius on animation progress.              
                shapes[i] = new PointF(
                    x + radius * (float)Math.Cos(i * 60 * Math.PI / 180f),
                    y + radius * (float)Math.Sin(i * 60 * Math.PI / 180f));
            }
            return shapes;
        }
        internal static PointF[] CreateDiamond(int x, int y, int radius)
        {            
            var shapes = new PointF[8];                     
            //Create 6 points
            for (int angle = 0; angle < 8; angle++)
            {  //- TODO: put this in a method. We need to create the shapes once and update the radius on animation progress.              
                shapes[angle] = new PointF(
                    x + radius * (float)Math.Cos(angle * 60 * Math.PI / 120f),
                    y + radius * (float)Math.Sin(angle * 60 * Math.PI / 120f));
            }            
            return shapes;
        }

        public static void DrawShadow(Graphics G, GraphicsPath GP, int d, Color pBackColor)
        {
            Color[] colors = GetColorVector(Color.Black, pBackColor, d).ToArray();
            for (int i = 0; i < d; i++)
            {
                G.TranslateTransform(1f, 0.75f);                // <== shadow vector!
                using (Pen pen = new Pen(colors[i], 1.75f))  // <== pen width (*)
                    G.DrawPath(pen, GP);
            }
            G.ResetTransform();
        }
        public static GraphicsPath CreateCircle(float x, float y, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(x, y, radius * 2, radius * 2);
            return gp;
        }

        private static List<Color> GetColorVector(Color fc, Color bc, int depth)
        {
            List<Color> cv = new List<Color>();
            float dRed = 1f * (bc.R - fc.R) / depth;
            float dGreen = 1f * (bc.G - fc.G) / depth;
            float dBlue = 1f * (bc.B - fc.B) / depth;
            for (int d = 1; d <= depth; d++)
                cv.Add(Color.FromArgb(60, (int)(fc.R + dRed * d),
                  (int)(fc.G + dGreen * d), (int)(fc.B + dBlue * d)));
            return cv;
        }
        public static Color RandomColor()
        {
            return Color.FromArgb(RandomFast.Next(255), RandomFast.Next(255), RandomFast.Next(255));
        }
    }
}
