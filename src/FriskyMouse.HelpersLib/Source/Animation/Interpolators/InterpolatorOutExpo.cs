using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorOutExpo : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {            
            return progress == 1 ? 1 : 1 - Math.Pow(2, -10 * progress);
        }
    }
}
