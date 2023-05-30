using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorOutQuint : IValueInterpolatable
    {        
        public double Interpolate(double progress)
        {
            return 1 - Math.Pow(1 - progress, 5);
        }
    }
}
