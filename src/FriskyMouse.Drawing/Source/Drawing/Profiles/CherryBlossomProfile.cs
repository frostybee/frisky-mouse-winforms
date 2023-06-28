using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class CherryBlossomProfile : BaseRippleProfile
    {
        private Pen _outlinePen;
        private SolidBrush _innerBrush;
        private SolidBrush _outerBrush;

        public CherryBlossomProfile()
        {
            CreateProfileEntries();
        }

        public void CreateProfileEntries()
        {
            _innerBrush = new SolidBrush(Color.Crimson);
            _outerBrush = new SolidBrush(Color.Crimson);
            _outlinePen = new Pen(Color.DarkBlue, 4);
                        
            //-- 1) Add the middle ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = BaseRadius ,
                    RadiusMultiplier = 3,
                    FillBrush = _outerBrush,
                    OutlinePen = _outlinePen,
                    IsFilled = true,
                    IsStyleable = true
                });            
            //-- 2) Inner ripple that must drawn last.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 6),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 6,
                    RadiusMultiplier = 2,
                    FillBrush = _innerBrush,
                    OutlinePen = _outlinePen,
                    IsFilled = true,
                });
            //-- 3) Add the outline ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 8),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = BaseRadius,
                    RadiusMultiplier = 3,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                });
        }
    }
}

