using System.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class SpotlightProfile : BaseProfile
    {        
        private SolidBrush _innerBrush;
        public SpotlightProfile()
        {
            InitProfileEntries();
        }
        private void InitProfileEntries()
        {
            Color rippleColor = Color.Crimson.ReduceOpacity(20);
            _innerBrush = new SolidBrush(rippleColor);
            //-- 1) Make the outer ripple.
            AddRipple(
                new RippleEntry()
                {
                    Expandable = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = BaseRadius,
                    RadiusMultiplier = 3,
                    FillBrush = _innerBrush,
                    IsFilled = true,
                });
        }
    }
}
