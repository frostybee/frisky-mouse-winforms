using System.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class DiamondProfile : BaseProfile
    {
        private Pen _outlinePen;
        int _baseRadius = 10; // Needs to be parametrized.

        public DiamondProfile()
        {
            InitProfileEntries();
        }

        private void InitProfileEntries()
        {
            int opacity = 10;
            int strokeWidth = 4;            
            _outlinePen = new Pen(Color.DarkBlue.ReduceOpacity(opacity), 4);
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
                    PolygonType = PolygonType.Diamond
                    //PolyPoints =  DrawingHelper.CreateHexagon(x, y, _baseRadius)
                });            
        }
    }
}
