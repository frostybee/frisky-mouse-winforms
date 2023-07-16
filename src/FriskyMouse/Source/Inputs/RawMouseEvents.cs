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

using FriskyMouse.NativeApi;

namespace FriskyMouse.Core;

public class RawMouseEvents
{

    public MouseButtonTypes MessageType { get; set; } = MouseButtonTypes.None;
    public POINT Point { get; set; }
    public uint MouseData { get; set; } = 0;
    public uint TimeStamp { get; set; } = 0;

}
