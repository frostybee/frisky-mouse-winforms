namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Represents an expanding, single circular ripple. 
    /// </summary>
    internal class CircleProfile : BaseRippleProfile 
    {
        private Pen _outlinePen;        
        public CircleProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _outlinePen = new Pen(Color.Crimson,  4);                        
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,                    
                    ShapeType = ShapeType.Ellipse,
                    IsFade = true,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    IsStyleable = true,
                });
        }        
    }
}
