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
/// using a piecewise simulated bounce function.
/// </summary>
public class BounceEaseInOut : Easing
{
    /// <inheritdoc/>
    public override double Ease(double progress)
    {
        double p = progress;
        if (p < 0.5d)
        {
            return 0.5f * (1 - BounceEaseUtils.Bounce(1 - (p * 2)));
        }
        else
        {
            return 0.5f * BounceEaseUtils.Bounce(p * 2 - 1) + 0.5f;
        }
    }
}
