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

using System.ComponentModel;

namespace FriskyMouse.Drawing.Animation;

/// <summary>
/// Defines the direction of the animation.
/// </summary>
public enum AnimationDirection : uint
{
    [Description("In")]
    In, // The animation will progress outward.
    [Description("Out")]
    Out, // The animation will progress inward.
    [Description("In Out In")]
    InOutIn //Same as In, but changes to InOutOut if finished.     
}
