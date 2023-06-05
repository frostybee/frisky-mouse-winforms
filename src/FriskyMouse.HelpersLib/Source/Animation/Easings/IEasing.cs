using FriskyMouse.HelpersLib;

namespace FrostyBee.FriskyRipples.Animation
{
    /// <summary>
    /// Defines the interface for easing classes.
    /// </summary>    
    public interface IEasing: IConstructable
    {
        /// <summary>
        /// Returns the value of the transition for the specified progress.
        /// </summary>
        double Ease(double progress);
    }
}
