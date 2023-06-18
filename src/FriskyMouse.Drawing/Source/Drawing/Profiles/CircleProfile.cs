using System.Drawing;
using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class CircleProfile : BaseRippleProfile 
    {
        private Pen _outlinePen;
        int _baseRadius = 10; // Needs to be parametrized.
        public CircleProfile()
        {
            InitProfileEntries();
        }

        private void InitProfileEntries()
        {
            int opacity = 10;            
            _outlinePen = new Pen(Color.Crimson.ReduceOpacity(opacity), 4);                        
            AddRipple(
                new RippleEntry()
                {
                    Expandable = true,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, _baseRadius),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                });
        }        
    }
}
