#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Linearly eases a <see cref="double"/> value.
    /// </summary>
    public class LinearEasing : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            return progress;
        }
    }
}
