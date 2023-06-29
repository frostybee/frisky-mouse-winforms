#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using System.ComponentModel;

namespace FriskyMouse.Helpers
{
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
}
