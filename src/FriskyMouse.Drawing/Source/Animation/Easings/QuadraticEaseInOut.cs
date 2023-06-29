#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases a <see cref="double"/> value 
    /// using a piece-wise quadratic function.
    /// </summary>
    public class QuadraticEaseInOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p = progress;

            if (progress < 0.5d)
            {
                return 2d * p * p;
            }
            else
            {
                return p * (-2d * p + 4d) - 1d;
            }           
        }
    }
}