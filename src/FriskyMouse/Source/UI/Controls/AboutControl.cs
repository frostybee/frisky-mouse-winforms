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

using FriskyMouse.Extensions;
using FriskyMouse.Helpers;

namespace FriskyMouse.UI.Controls;

public partial class AboutControl : UserControl
{
    public AboutControl()
    {
        InitializeComponent();
        this.DisableAutoScaleMode(664, 693);
        LoadBuildInfo();
    }
    public void LoadBuildInfo()
    {
        // TODO: add suffix indicating latest or not up to date.
        // Maybe add status field? latest, udpate  with latest version info?
        lblAppVersion.Text = $"Version: {FMAppHelpers.GetApplicationVersion()}";
        lblBuildInfo.Text = $"Build: {Program.BuildInfo}";
    }

    private void BtnWebstie_Click(object sender, EventArgs e)
    {
        FMAppHelpers.OpenURL(FMAppLinks.WebsiteURL);
    }

    private void BtnDeveloper_Click(object sender, EventArgs e)
    {
        FMAppHelpers.OpenURL(FMAppLinks.DeveloperURL);
    }

    private void BtnLicense_Click(object sender, EventArgs e)
    {
        FMAppHelpers.OpenURL(FMAppLinks.LicenseURL);
    }

    private void BtnDonate_Click(object sender, EventArgs e)
    {
        FMAppHelpers.OpenURL(FMAppLinks.DonationURL);
    }
}
