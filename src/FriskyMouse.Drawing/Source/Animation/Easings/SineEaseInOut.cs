#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases a <see cref="double"/> value 
    /// using a half sine wave function.
    /// </summary>
    public class SineEaseInOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            return 0.5d * (1d - Math.Cos(progress * Math.PI));
        }
    }
}
