namespace FrostyBee.FriskyRipples.Animation
{
    /// <summary>
    /// Base class for all Easing classes.
    /// </summary>    
    public abstract partial class Easing : IEasing
    {
        /// <inheritdoc/>
        public abstract double Ease(double progress);

        private const string Namespace = "FrostyBee.FriskyRipples.Animation"; 
    }
}
