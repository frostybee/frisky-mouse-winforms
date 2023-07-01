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

namespace FriskyMouse.Drawing.Animation;

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
