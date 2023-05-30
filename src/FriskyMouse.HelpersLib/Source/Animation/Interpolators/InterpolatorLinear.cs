namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorLinear : IValueInterpolatable
    {        

        public double Interpolate(double progress)
        {
            return progress;
        }
    }
}
