using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class SquareProfile : BaseRippleProfile
    {
        private SolidBrush brush;
        private Pen _outlinePen;
        int _baseRadius = 10; // Needs to be parametrized.
        public SquareProfile()
        {
            InitProfileEntries();
        }
        private void InitProfileEntries()
        {
            brush = new SolidBrush(Color.DarkBlue.ReduceOpacity(_baseRadius * 10));
            _outlinePen = new Pen(Color.DarkBlue.ReduceOpacity(_baseRadius * 10), 4);

            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    Expandable = true,
                    ShapeType = ShapeType.Rectangle,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, _baseRadius),
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    FillBrush = brush,
                    OutlinePen = _outlinePen,
                    IsFilled = true,
                });
        }         
    }
}
