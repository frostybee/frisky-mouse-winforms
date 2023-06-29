#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases out a <see cref="double"/> value 
    /// using the shifted second quadrant of
    /// the unit circle.
    /// </summary>
    public class CircularEaseOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p = progress;
            return Math.Sqrt((2d - p) * p);
         }
    }
}
