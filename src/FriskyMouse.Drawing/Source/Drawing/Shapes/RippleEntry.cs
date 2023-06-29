#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents a ripple entry having various shapes.
    /// The ripple can be either fixed or expandable. 
    /// </summary>
    public class RippleEntry
    {
        public ShapeType ShapeType { get; set; } = ShapeType.Ellipse;
        public bool IsFilled { get; set; } = false;
        public bool IsExpandable { get; set; } = true;
        public bool IsFade { get; set; } = true;
        public bool IsStyleable { get; set; } = false;
        public float RadiusMultiplier { get; set; } = 2.2f;
        public int InitialRadius { get; set; } = 10;        
        public Rectangle Bounds { get; set; }
        public SolidBrush FillBrush { get; set; }
        public Pen OutlinePen { get; set; }
        public PointF[] PolyPoints { get; set; }
        public PolygonType PolygonType { get; set; }        
        private int _expandedRadius = 1;
        private Color _initialFillColor = Color.Red;
        private Color _initialOutlineColor = Color.Red;
        private const int MAX_RADIUS = 200;
        private const int MAX_WIDTH = 200;        

        /// <summary>
        /// Draws a ripple entry.
        /// </summary>
        /// <param name="graphics">The canvas on which the ripple/shape will be drawn.</param>
        internal void Draw(Graphics graphics)
        {
            switch (ShapeType)
            {
                case ShapeType.Crosshair:
                    graphics.FillRectangle(FillBrush, Bounds);
                    break;
                case ShapeType.Ellipse:
                    if (IsFilled)
                    {
                        graphics.FillEllipse(FillBrush, Bounds);
                    }
                    else
                    {
                        graphics.DrawEllipse(OutlinePen, Bounds);
                    }
                    break;
                case ShapeType.Rectangle:
                    graphics.DrawRectangle(OutlinePen, Bounds);
                    break;
                case ShapeType.Polygon:
                    var x = MAX_RADIUS / 2;
                    var y = MAX_RADIUS / 2;
                    switch (PolygonType)
                    {
                        case PolygonType.Diamond:
                            PolyPoints = DrawingHelper.CreateDiamond(x, y, _expandedRadius);
                            break;
                        case PolygonType.Hexagon:
                            PolyPoints = DrawingHelper.CreateHexagon(x, y, _expandedRadius);
                            break;
                        case PolygonType.Star:
                            PolyPoints = DrawingHelper.CreateStarShape(MAX_WIDTH, _expandedRadius);
                            break;
                        default:
                            break;
                    }
                    graphics.DrawPolygon(OutlinePen, PolyPoints.ToArray());
                    break;
            }
        }


        internal void AdjustColorOpacity(double animationProgress, int opacityMultiplier)
        {
            int opacity = 255;
            // Opacity percentage: 255 * 75 / 100
            float percentage = (float)Math.Round(animationProgress * opacityMultiplier, 2);
            opacity = Math.Clamp(255 * (int)percentage / 100, 1, 255);
            if (IsFade)
            {
                if (IsFilled)
                {
                    FillBrush.Color = _initialFillColor.ReduceOpacity(opacity);
                }
                else
                {
                    OutlinePen.Color = _initialOutlineColor.ReduceOpacity(opacity);
                }
            }
        }

        internal void ExpandRadius(double progress, int multiplier)
        {
            if (IsExpandable)
            {
                int radius = (int)(progress * CalculateNewRadius(multiplier));
                _expandedRadius = Math.Clamp(radius, 1, MAX_RADIUS / 2);
                // Create a new bounding rectangle based on the newly expanded radius. 
                Bounds = DrawingHelper.CreateRectangle(MAX_RADIUS, MAX_RADIUS, _expandedRadius);
            }
        }

        private double CalculateNewRadius(int multiplier)
        {
            return InitialRadius * RadiusMultiplier * (multiplier / 10d);
        }

        internal void ResetColorOpacity(byte initialOpacity)
        {
            if (IsFade)
            {
                if (IsFilled)
                {
                    FillBrush.Color = FillBrush.Color.WithOpacity(initialOpacity);
                    _initialFillColor = FillBrush.Color;
                }
                else
                {
                    OutlinePen.Color = OutlinePen.Color.WithOpacity(initialOpacity);
                    _initialOutlineColor = OutlinePen.Color;
                }
            }
        }

        internal void ChangeColor(RippleProfileOptions options)
        {
            if (IsStyleable)
            {
                if (IsFilled)
                {
                    FillBrush.Color = Color.FromArgb(FillBrush.Color.A, options.FillColor);

                }
                else
                {
                    OutlinePen.Color = Color.FromArgb(OutlinePen.Color.A, options.FillColor);
                }
            }
        }
    }
}
