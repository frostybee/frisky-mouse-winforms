namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorOutBounce : IValueInterpolatable
    {        

        public double Interpolate(double time)
        {
            double n1 = 7.5625;
            double d1 = 2.75;

            if (time < 1 / d1)
            {
                return n1 * time * time;
            }
            else if (time < 2 / d1)
            {
                return n1 * (time -= 1.5 / d1) * time + 0.75;
            }
            else if (time < 2.5 / d1)
            {
                return n1 * (time -= 2.25 / d1) * time + 0.9375;
            }
            else
            {
                return n1 * (time -= 2.625 / d1) * time + 0.984375;
            }
        }
    }
}
