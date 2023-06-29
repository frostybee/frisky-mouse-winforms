#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases in a <see cref="double"/> value 
    /// using the shifted fourth quadrant of
    /// the unit circle.
    /// </summary>
    public class CircularEaseIn : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double p)
        {
            return 1d - Math.Sqrt(1d - p * p);
        }
    }
}
