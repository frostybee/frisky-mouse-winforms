#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.NativeApi;

namespace FriskyMouse.Core
{
    public class RawMouseEvents
    {

        public MouseButtonTypes MessageType { get; set; } = MouseButtonTypes.None;
        public POINT Point { get; set; }
        public uint MouseData { get; set; } = 0;
        public uint TimeStamp { get; set; } = 0;

    }
}
