using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class HexagonProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        int _baseRadius = 10; // Needs to be parametrized.

        public HexagonProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _outlinePen = new Pen(Color.Crimson, 4);
            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, _baseRadius),
                    ShapeType = ShapeType.Polygon,
                    InitialRadius = _baseRadius,
                    RadiusMultiplier = 2,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    PolygonType = PolygonType.Hexagon,
                    IsStyleable = true,                    
                });
        }
    }
}
