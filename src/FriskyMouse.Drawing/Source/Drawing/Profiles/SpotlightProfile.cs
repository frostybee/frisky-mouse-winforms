using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class SpotlightProfile : BaseRippleProfile
    {        
        private SolidBrush _innerBrush;
        public SpotlightProfile()
        {
            CreateProfileEntries();
        }
        private void CreateProfileEntries()
        {
            _innerBrush = new SolidBrush(Color.Crimson);            
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = BaseRadius,
                    RadiusMultiplier = 3,
                    FillBrush = _innerBrush,
                    IsFilled = true,
                    IsFade = true,
                    IsStyleable = true
                });
        }
    }
}
