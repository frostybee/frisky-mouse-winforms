using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents a single expanding ripple.
    /// </summary>
    internal class SquaredPulseProfile : BaseRippleProfile
    {
        // TODO: add IsFilled. Color Transition: enabled/disabled.
        // Add random color?        
        private Pen _outlinePen;
        private SolidBrush _innerBrush;
        private SolidBrush _outerBrush;

        public SquaredPulseProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _innerBrush = new SolidBrush(Color.DarkBlue);
            _outerBrush = new SolidBrush(Color.Crimson);

            _outlinePen = new Pen(Color.DeepPink, 4);
            // 1) Make the outer most ripple.            
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius+5),
                    ShapeType = ShapeType.Rectangle,
                    InitialRadius = BaseRadius+5,
                    IsFade = true,
                    RadiusMultiplier = 2,
                    FillBrush = _outerBrush,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    IsStyleable = true
                });
            //-- 2) Inner ripple that must drawn last.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 7),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 10,
                    IsFade  = false,
                    RadiusMultiplier = 2,
                    FillBrush = _innerBrush,
                    OutlinePen = _outlinePen,
                    IsFilled = true,
                });
        }        
    }
}
