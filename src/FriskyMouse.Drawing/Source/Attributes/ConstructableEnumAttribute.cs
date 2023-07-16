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

namespace FriskyMouse.Drawing.Attributes;

[AttributeUsage(AttributeTargets.Field)]
internal class ConstructableEnumAttribute : Attribute
{
    public Type Type { get; set; }
    public ConstructableEnumAttribute(Type type)
    {
        Type = type;
    }
}
