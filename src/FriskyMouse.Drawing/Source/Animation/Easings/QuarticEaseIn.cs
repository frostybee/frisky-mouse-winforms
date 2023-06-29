#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases in a <see cref="double"/> value 
    /// using a quartic equation.
    /// </summary>
    public class QuarticEaseIn : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p2 = progress * progress;
            return p2 * p2;
        }
    }
}
