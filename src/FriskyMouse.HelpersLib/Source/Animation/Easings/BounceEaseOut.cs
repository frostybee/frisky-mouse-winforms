namespace FrostyBee.FriskyRipples.Animation
{
    /// <summary>
    /// Eases out a <see cref="double"/> value 
    /// using a simulated bounce function.
    /// </summary>
    public class BounceEaseOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            return BounceEaseUtils.Bounce(progress);
        }
    }
}
