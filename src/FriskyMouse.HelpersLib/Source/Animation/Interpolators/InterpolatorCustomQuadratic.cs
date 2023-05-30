using System;

namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorCustomQuadratic: IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            //double kickoff = 0.6;
            double kickoff = 0.3;
            return 1 - Math.Cos((Math.Max(progress, kickoff) - kickoff) * Math.PI / (2 - (2 * kickoff)));
        }
    }
}
