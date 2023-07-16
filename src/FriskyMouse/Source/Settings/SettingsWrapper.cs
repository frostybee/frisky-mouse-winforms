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

using FriskyMouse.Drawing.Ripples;

namespace FriskyMouse.Settings;

internal class SettingsWrapper
{
    #region Properties                
    public ApplicationSettings ApplicationSettings { get; set; } = new ApplicationSettings();

    public HighlighterOptions HighlighterOptions { get; set; } = new HighlighterOptions();
    public RippleProfileOptions LeftClickOptions { get; set; } = new RippleProfileOptions();
    public RippleProfileOptions RightClickOptions { get; set; } = new RippleProfileOptions();

    #endregion

}
