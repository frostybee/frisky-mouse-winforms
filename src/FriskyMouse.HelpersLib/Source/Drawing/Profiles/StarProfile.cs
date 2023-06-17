using System.Drawing;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class StarProfile : RippleProfile
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
