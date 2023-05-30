using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorInOutCubic : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            return progress < 0.5 ? 4 * Math.Pow(progress, 3) : 1 - Math.Pow(-2 * progress + 2, 3) / 2;
        }
    }
}
