namespace FriskyMouse.HelpersLib.Animation
{
    internal class InterpolatorInOutBounce : IValueInterpolatable
    {
        private readonly InterpolatorOutBounce _outBounceInterpolator = new InterpolatorOutBounce();
        public double Interpolate(double time)
        {
            return time < 0.5
                  ? (1 - _outBounceInterpolator.Interpolate(1 - 2 * time)) / 2
                  : (1 + _outBounceInterpolator.Interpolate(2 * time - 1)) / 2;
        }
    }
}
