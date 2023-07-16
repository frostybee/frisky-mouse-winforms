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

using MaterialSkin;

namespace FriskyMouse.Settings;

public class ApplicationSettings
{
    #region Properties        

    public string ApplicationName { get; set; } = "FriskyMouse";
    public string Version { get; set; } = string.Empty;
    public ColorSchemeType ColorScheme { get; set; } = ColorSchemeType.Indigo;
    public bool UseDarkTheme { get; set; } = false;
    public bool UseColoredDrawer { get; set; } = false;

    #endregion
}

