using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class StarProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        public StarProfile()
        {
            InitProfileEntries();
        }
        private void InitProfileEntries()
        {            
            _outlinePen = new Pen(Color.Crimson, 4);            

            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    Expandable = true,
                    ShapeType = ShapeType.Polygon,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 20),
                    InitialRadius = 10,
                    RadiusMultiplier = 3,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    PolygonType = PolygonType.Star
                });
        }
    }
}
