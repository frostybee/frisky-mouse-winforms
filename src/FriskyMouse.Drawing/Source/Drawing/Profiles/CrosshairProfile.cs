namespace FriskyMouse.Drawing.Ripples
{
    internal class CrosshairProfile : BaseRippleProfile
    {
        private SolidBrush _verticalBrush;
        private SolidBrush _horizontalBrush;
        public CrosshairProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {            
            int width = 40;
            int height = 8;            
            _verticalBrush = new SolidBrush(Color.DarkBlue);
            _horizontalBrush = new SolidBrush(Color.Crimson);            
            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = new Rectangle((200/ 2) - 4, (200 / 2) - 20, height, width),
                    ShapeType = ShapeType.Crosshair,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    FillBrush = _verticalBrush,
                    IsFilled = true,
                });
            AddRipple(
             new RippleEntry()
             {
                 IsExpandable = false,
                 Bounds = new Rectangle((200 / 2) - 20, (200 / 2) - 4, width, height),
                 ShapeType = ShapeType.Crosshair,
                 InitialRadius = 10,
                 RadiusMultiplier = 2,
                 FillBrush = _horizontalBrush,
                 IsFilled = true,
             });
        }       
    }
}
