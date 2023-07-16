#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.Drawing.Animation;

/// <summary>
/// Eases a <see cref="double"/> value 
/// using a piece-wise cubic equation.
/// </summary>
public class CubicEaseInOut : Easing
{
    /// <inheritdoc/>
    public override double Ease(double progress)
    {
        double p = progress;

        if (progress < 0.5d)
        {
            return 4d * p * p * p;
        }
        else
        {
            double f = 2d * (p - 1);
            return 0.5d * f * f * f + 1d;
        }
    }
}
