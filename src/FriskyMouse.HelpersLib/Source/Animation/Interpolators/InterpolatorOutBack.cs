using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorOutBack : IValueInterpolatable
    {        
        private const double c1 = 2.70158;
        private const double c3 = c1 + 1;
        public double Interpolate(double progress)
        {
            return 1 + c3 * Math.Pow(progress - 1, 3) + c1 * Math.Pow(progress - 1, 2);
        }
    }
}
