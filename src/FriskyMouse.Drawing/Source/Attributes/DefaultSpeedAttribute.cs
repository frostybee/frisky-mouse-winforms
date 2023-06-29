#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DefaultSpeedAttribute : Attribute
    {
        public int Speed { get; set; }
        public DefaultSpeedAttribute(int pSpeed) {
            Speed = pSpeed;
        }
    }
}
