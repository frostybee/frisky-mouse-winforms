using System.Drawing;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class StarProfile : BaseProfile
    {

        Pen _outlinePen;
        public StarProfile()
        {
            InitProfileEntries();
        }
        private void InitProfileEntries()
        {
            //TODO: store in the settings the stroke width of the pen.
            // And the style/dashed/dot
            _outlinePen = new Pen(Color.Crimson, 4);
            //_outlinePen.DashStyle = DashStyle.Dot;

            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
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
