#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Eases a <see cref="double"/> value 
    /// using a piecewise overshooting cubic function.
    /// </summary>    
    public class BackEaseInOut : Easing
    {
        /// <inheritdoc/>
        public override double Ease(double progress)
        {
            double p = progress;

            if (p < 0.5d)
            {
                double f = 2d * p;
                return 0.5d * f * (f * f - Math.Sin(f * Math.PI));
            }
            else
            {
                double f = (1d - (2d * p - 1d));
                return 0.5d * (1d - f * (f * f - Math.Sin(f * Math.PI))) + 0.5d;
            }
        }
    }
}
