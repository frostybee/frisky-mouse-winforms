using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorInQuint : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            return Math.Pow(progress, 5);
        }
    }
}
