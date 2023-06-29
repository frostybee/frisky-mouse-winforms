#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases out a <see cref="double"/> value 
    /// using the quarter-wave of sine function
    /// with shifted phase.
    /// </summary>
    public class SineEaseOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            return Math.Sin(progress * EasingUtils.HALFPI);
        }
    }
}
