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
            CreateProfileEntries();
        }
        private void CreateProfileEntries()
        {
            brush = new SolidBrush(Color.DarkBlue.ReduceOpacity(_baseRadius * 10));
            _outlinePen = new Pen(Color.DarkBlue.ReduceOpacity(_baseRadius * 10), 4);

            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    ShapeType = ShapeType.Rectangle,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, _baseRadius),
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    FillBrush = brush,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    IsStyleable = true,
                });
        }         
    }
}
