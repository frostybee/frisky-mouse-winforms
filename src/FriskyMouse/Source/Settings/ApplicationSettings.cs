#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using MaterialSkin;

namespace FriskyMouse.Settings;

public class ApplicationSettings
{
    #region Properties        
    public string ApplicationName { get; set; } = "FriskyMouse";
    public string Version { get; set; } = string.Empty;
    public ColorSchemeType ColorScheme { get; set; } = ColorSchemeType.Blue;

    #endregion
}

