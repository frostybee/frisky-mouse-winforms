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
/// Helper static class for BounceEase classes.
/// </summary>
internal static class BounceEaseUtils
{
    /// <summary>
    /// Returns the consequent <see cref="double"/> value of
    /// a simulated bounce function.
    /// </summary>
    /// <param name="progress">The amount of progress from 0 to 1.</param>
    /// <returns>The result of the easing function</returns>
    internal static double Bounce(double progress)
    {
        double p = progress;
        if (p < 4d / 11.0d)
        {
            return (121d * p * p) / 16.0d;
        }
        else if (p < 8d / 11.0d)
        {
            return (363d / 40.0d * p * p) - (99d / 10.0d * p) + 17d / 5.0d;
        }
        else if (p < 9d / 10.0d)
        {
            return (4356d / 361.0d * p * p) - (35442d / 1805.0d * p) + 16061d / 1805.0d;
        }
        else
        {
            return (54d / 5.0d * p * p) - (513d / 25.0d * p) + 268d / 25.0d;
        }
    } 
}
