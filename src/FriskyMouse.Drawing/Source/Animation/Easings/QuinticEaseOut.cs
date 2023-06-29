#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases out a <see cref="double"/> value 
    /// using a quartic equation.
    /// </summary>
    public class QuinticEaseOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double f = (progress - 1d);
            double f2 = f * f;
            return f2 * f2 * f + 1d;
        }
    }
}
