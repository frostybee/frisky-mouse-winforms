#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using System.Drawing.Imaging;

namespace FriskyMouse.Drawing.Helpers;

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
        middleX -= radius;
        middleY -= radius;
        // Create an array of points.
        PointF[] points =
                 {
             new Point(Convert.ToInt32(middleX + radius * (0.5 + min)), Convert.ToInt32(middleY + radius * (0.84 + min))),
             new Point(Convert.ToInt32(middleX + radius * (1.5f + min)), Convert.ToInt32(middleY + radius * (0.84f + min))),
             new Point(Convert.ToInt32(middleX + radius * (0.68f + min)), Convert.ToInt32(middleY + radius * (1.45f + min))),
             new Point(Convert.ToInt32(middleX + radius * (1.0f + min)), Convert.ToInt32(middleY + radius * (0.5f + min))),
             new Point(Convert.ToInt32(middleX + radius * (1.32f + min)), Convert.ToInt32(middleY + radius * (1.45f + min))),
             new Point(Convert.ToInt32(middleX + radius * (0.5f + min)), Convert.ToInt32(middleY + radius * (0.84f + min))),
         };
        return points;
    }

    internal static PointF[] CreateHexagon(int x, int y, int radius)
    {
        return GetPolygonPoints(x, y, radius, 6, 180f);
    }

    internal static PointF[] CreateDiamond(int x, int y, int radius)
    {
        return GetPolygonPoints(x, y, radius, 8, 120f);
    }

    internal static PointF[] GetPolygonPoints(int x, int y, int radius, int edgesCount, float degree)
    {
        PointF[] points = new PointF[edgesCount];
        for (int i = 0; i < edgesCount; i++)
        {
            points[i] = new PointF(
                x + radius * (float)Math.Cos(i * 60 * Math.PI / degree),
                y + radius * (float)Math.Sin(i * 60 * Math.PI / degree));
        }
        return points;
    }
}
