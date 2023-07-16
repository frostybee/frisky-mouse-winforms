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

using System.ComponentModel;

namespace FriskyMouse.Helpers;

public enum OutlineStyle: uint
{
    [Description("Solid")]
    Solid = 0,
    [Description("Dashed")]
    Dash = 1,
    [Description("Dotted")]
    Dot = 2,
    [Description("Dash Dot")]
    DashDot = 3,
    [Description("Dash Dot Dot")]
    DashDotDot = 4        
}
