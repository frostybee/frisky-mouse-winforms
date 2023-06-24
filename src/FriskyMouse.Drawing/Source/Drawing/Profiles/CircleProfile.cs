using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

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
            int opacity = 10;            
            _outlinePen = new Pen(Color.Crimson.ReduceOpacity(opacity),  4);                        
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,
                    //Bounds = DrawingHelper.CreateRectangle(Width, Height, BaseRadius),
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
