using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;
using System.Diagnostics;

namespace FriskyMouse.Drawing.Ripples
{
    public class RippleEntry
    {
        public ShapeType ShapeType { get; set; } = ShapeType.Ellipse;
        public bool IsFilled { get; set; } = false;
        public bool IsExpandable { get; set; } = true;
        public bool IsFade { get; set; } = true;
        public bool IsStyleable { get; set; } = false;
        public float RadiusMultiplier { get; set; } = 2.2f;
        public int InitialRadius { get; set; } = 10;
        public int Opacity { get; set; }
        public int OutlineWidth { get; set; } = 4;
        public Rectangle Bounds { get; set; }
        public SolidBrush FillBrush { get; set; }
        public Pen OutlinePen { get; set; }
        public PointF[] PolyPoints { get; set; }
        public PolygonType PolygonType { get; set; }
        public double ExpandedRadius { get { return InitialRadius * RadiusMultiplier; } }
        private int _expandedRadius = 1;
        private Color _initialFillColor = Color.Red;
        private Color _initialOutlineColor = Color.Red;


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
                    var x = 200 / 2;
                    var y = 200 / 2;
                    switch (PolygonType)
                    {
                        case PolygonType.Diamond:
                            PolyPoints = DrawingHelper.CreateDiamond(x, y, _expandedRadius);
                            break;
                        case PolygonType.Hexagon:
                            PolyPoints = DrawingHelper.CreateHexagon(x, y, _expandedRadius);
                            break;
                        case PolygonType.Star:
                            PolyPoints = DrawingHelper.CreateStarShape(200, _expandedRadius);
                            break;
                        default:
                            break;
                    }
                    graphics.DrawPolygon(OutlinePen, PolyPoints.ToArray());
                    break;
            }
        }

        /*internal void AdjustColorOpacity(double animationProgress)
        {
            //return (255 - Math.Min(Math.Max(0, (int)animationProgress* 150), 255));
            int opacity = 1;
            // Opacity percentage: 255 * 75 / 100
            float percentage = (float)Math.Round(animationProgress * 80, 2);
            opacity = Math.Max(1, Math.Min(255 * (int)percentage / 100, 255));
            if (IsFade)
            {
                if (IsFilled)
                {
                    FillBrush.Color = FillBrush.Color.ReduceOpacity(opacity);
                    //FillBrush.Color = DrawingHelper.RandomColor().ReduceOpacity(opacity);
                }
                else
                {
                    OutlinePen.Color = OutlinePen.Color.ReduceOpacity(opacity);
                }
            }
        }*/
        internal void AdjustColorOpacity(double animationProgress)
        {
            int opacity = 1;
            // Opacity percentage: 255 * 75 / 100
            float percentage = (float)Math.Round(animationProgress * 30, 2);
            opacity = Math.Max(1, Math.Min(255 * (int)percentage / 100, 255));
            if (IsFade)
            {
                if (IsFilled)
                {
                    FillBrush.Color = _initialFillColor.ReduceOpacity(opacity);
                    //FillBrush.Color = DrawingHelper.RandomColor().ReduceOpacity(opacity);
                }
                else
                {
                    Debug.WriteLine("opacity: " + opacity);
                    OutlinePen.Color = _initialOutlineColor.ReduceOpacity(opacity);
                }
            }
        }

        internal void ExpandRadius(double progress)
        {
            if (IsExpandable)
            {
                // TODO: Take into consideration the MaxRadius.
                // TODO: Clamp the radius. 
                _expandedRadius = Math.Min(Math.Max(1, (int)(progress * CalculateNewRadius())), 200 / 2);
                //int newRadius = (int)();
                // Create a new bounding rectangle based on the newly expanded radius. 
                Bounds = DrawingHelper.CreateRectangle(200, 200, _expandedRadius);
            }
        }

        internal double CalculateNewRadius()
        {
            return InitialRadius * RadiusMultiplier;
            // TODO: parametrize the last value: make it a slider that ranges
            // between 1 and 2. 
            //return InitialRadius * RadiusMultiplier * 2;
        }

        /* internal void ResetColorOpacity(byte initialOpacity)
         {
             if (IsFade)
             {
                 if (IsFilled)
                 {
                     FillBrush.Color = FillBrush.Color.WithOpacity(initialOpacity);
                     //FillBrush.Color = DrawingHelper.RandomColor().ReduceOpacity(opacity);
                 }
                 else
                 {
                     OutlinePen.Color = OutlinePen.Color.WithOpacity(initialOpacity);
                 }
             }
         }*/
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
                    //OutlinePen.Color = OutlinePen.Color.WithOpacity(initialOpacity);
                    OutlinePen.Color = Color.FromArgb(OutlinePen.Color.A, options.FillColor);
                }
            }
        }
    }
}
