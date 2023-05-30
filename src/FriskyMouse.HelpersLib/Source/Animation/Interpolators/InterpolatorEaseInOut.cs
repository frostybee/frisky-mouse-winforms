using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorEaseInOut : IValueInterpolatable
    {
        public double Interpolate(double time)
        {            
            return -(Math.Cos(Math.PI * time) - 1) / 2;
        }

    }
}
