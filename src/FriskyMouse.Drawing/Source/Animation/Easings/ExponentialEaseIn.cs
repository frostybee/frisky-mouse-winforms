#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases in a <see cref="double"/> value 
    /// using a exponential function.
    /// </summary>
    public class ExponentialEaseIn : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p = progress;
            return (p == 0.0d) ? p : Math.Pow(2d, 10d * (p - 1d));
        }
    }
}
