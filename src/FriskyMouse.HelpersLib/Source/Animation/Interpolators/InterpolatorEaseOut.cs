using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorEaseOut : IValueInterpolatable
    {        
        public double Interpolate(double progress)
        {            
            return Math.Sin((progress * Math.PI) / 2);

        }
    }
}
