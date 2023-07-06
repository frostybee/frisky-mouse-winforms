#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Helpers;

namespace FriskyMouse.UI.Controls;

public partial class AboutControl : UserControl
{
    public AboutControl()
    {
        InitializeComponent();
        //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        LoadBuildInfo();
    }
    public void LoadBuildInfo()
    {
        // TODO: add suffix indicating latest or not up to date.
        // Maybe add status field? latest, udpate  with latest version info?
        lblAppVersion.Text = $"Version: {AppHelpers.GetApplicationVersion()}";
        lblBuildInfo.Text = $"Build: {Program.BuildInfo}";
    }
}
