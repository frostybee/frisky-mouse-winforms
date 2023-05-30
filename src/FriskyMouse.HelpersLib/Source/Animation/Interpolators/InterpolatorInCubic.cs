using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorInCubic : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            return Math.Pow(progress, 3);
        }
    }
}
