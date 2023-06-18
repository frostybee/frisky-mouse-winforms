using System.Drawing;
using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents a single expanding ripple.
    /// </summary>
    internal class IceCreamProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        private SolidBrush _innerBrush;
        private SolidBrush _outerBrush;
        private int _baseRadius = 4;
        public IceCreamProfile()
        {
            InitProfileEntries();
        }

        private void InitProfileEntries()
        {
            _outlinePen = new Pen(Color.Crimson.WithOpacity(200), 4);

            //-- 1) Add the middle ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius + 3,
                    RadiusMultiplier = 3,
                    FillBrush = _outerBrush,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(80), 8),
                    IsFilled = false,
                });
            /*//-- 2) Add the outline ripple.
            AddRipple(
                new RippleEntry()
                {
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius + 3),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 6 + 2,
                    RadiusMultiplier = 3,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(100), 6),
                    IsFilled = false,
                });*/
            //-- 2) Add the outline ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius + 3),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius + 1,
                    RadiusMultiplier = 3,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(130), 8),
                    IsFilled = false,
                });
            //-- 3) Inner ripple that must drawn last.
            AddRipple(
                new RippleEntry()
                {
                    IsFade = false,
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius + 6),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = _baseRadius,
                    RadiusMultiplier = 2,
                    FillBrush = _innerBrush,
                    OutlinePen = new Pen(Color.Crimson.WithOpacity(100), 8),
                    IsFilled = false,
                });
        }
    }
}

