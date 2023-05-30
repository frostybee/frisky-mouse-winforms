using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorInExpo : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            return progress == 0 ? 0 : Math.Pow(2, 10 * progress - 10);
        }
    }
}
