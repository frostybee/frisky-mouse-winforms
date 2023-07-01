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

using System.Reflection;

namespace FriskyMouse.Drawing.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Retrieves an attribute associated with the supplied enum value by its type. 
    /// </summary>
    /// <typeparam name="TAttribute">The type of the attribute on which the lookup should be performed.</typeparam>
    /// <param name="value">The enum value whose attribute will be returned.</param>
    /// <returns></returns>
    public static TAttribute GetEnumAttribute<TAttribute>(this Enum value)
    where TAttribute : Attribute
    {
        var type = value.GetType();
        var name = Enum.GetName(type, value);
        return type.GetField(name)
            .GetCustomAttribute<TAttribute>();
    }
}
