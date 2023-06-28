using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents a single expanding ripple.
    /// </summary>
    public class FilledSonarPulseProfile : BaseRippleProfile
    {
        private SolidBrush _innerBrush;
        private SolidBrush _outerBrush;
        private Pen _middlePen;
        public FilledSonarPulseProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _innerBrush = new SolidBrush(Color.DeepPink);
            _outerBrush = new SolidBrush(Color.DarkGreen);
            _middlePen = new Pen(Color.White, 3);

            // 1) Make the outer ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 15),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = BaseRadius,
                    RadiusMultiplier = 3,
                    FillBrush = _outerBrush,
                    IsFilled = true,
                    IsStyleable = true
                });
            // 2) Make the middle ripple. 
            AddRipple(   
                new RippleEntry()
                {
                    IsExpandable = false,
                    IsFade = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 9),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 9,
                    RadiusMultiplier = 2,
                    OutlinePen = _middlePen,
                    IsFilled = false,
                });
            // 3) Make the most inner ripple. It must drawn last.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    IsFade = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 8),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 8,
                    RadiusMultiplier = 2,
                    FillBrush = _innerBrush,
                    IsFilled = true,
                });
        }
    }
}
