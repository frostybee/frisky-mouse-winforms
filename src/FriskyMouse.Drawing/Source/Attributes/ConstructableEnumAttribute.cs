#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ConstructableEnumAttribute : Attribute
    {
        public Type Type { get; set; }
        public ConstructableEnumAttribute(Type type)
        {
            Type = type;
        }
    }
}
