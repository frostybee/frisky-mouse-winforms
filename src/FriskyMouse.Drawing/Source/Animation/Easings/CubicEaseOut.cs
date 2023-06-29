#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases out a <see cref="double"/> value 
    /// using a cubic equation.
    /// </summary>
    public class CubicEaseOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double f = (progress - 1d);
            return f * f * f + 1d;
        }
    }
}
