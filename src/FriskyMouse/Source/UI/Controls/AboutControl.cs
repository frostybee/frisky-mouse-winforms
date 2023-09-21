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

using FriskyMouse.Core;
using FriskyMouse.Extensions;
using FriskyMouse.Helpers;
using FriskyMouse.Settings;
using System.Diagnostics;
using System.Globalization;

namespace FriskyMouse.UI.Controls;

public partial class AboutControl : UserControl
{
    private readonly GitHubUpdateChecker _updateChecker = new GitHubUpdateChecker();
    private readonly ApplicationSettings _settings;
    public AboutControl()
    {
        InitializeComponent();
        this.DisableAutoScaleMode(664, 693);
        _settings = SettingsManager.Settings.ApplicationSettings;
        LoadBuildInfo();
    }
    public void LoadBuildInfo()
    {
        // TODO: add suffix indicating latest or not up to date.
        // Maybe add status field? latest, udpate  with latest version info?
        lblAppVersion.Text = $"Current version: {FMAppHelper.GetApplicationVersion()}";
        lblBuildInfo.Text = $"Build: {Program.BuildInfo}";
    }

    private void BtnWebstie_Click(object sender, EventArgs e)
    {
        FMAppHelper.OpenURL(FMAppLinks.WebsiteURL);
    }

    private void BtnDeveloper_Click(object sender, EventArgs e)
    {
        FMAppHelper.OpenURL(FMAppLinks.DeveloperURL);
    }

    private void BtnLicense_Click(object sender, EventArgs e)
    {
        FMAppHelper.OpenURL(FMAppLinks.LicenseURL);
    }

    private void BtnDonate_Click(object sender, EventArgs e)
    {
        FMAppHelper.OpenURL(FMAppLinks.DonationURL);
    }

    internal void CheckForUpdate()
    {
        CheckForLatestVersion();
    }
    private async void CheckForLatestVersion()
    {
        if (IsCheckForUpdateRequired())
        {
            await Task.Run(_updateChecker.CheckGitHubNewerVersion);
            if (_updateChecker.IsUpdateAvailable)
            {
                MessageBox.Show("A new version is available, please consider updating FriskyMouse!"
                    , "FriskyMouse Update"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
                UpdateLatestVerionLabel(_updateChecker.NewVersionInfo);
            }
            else
            {
                UpdateLatestVerionLabel("Up to date!");
            }
        }
        else
        {
            UpdateLatestVerionLabel("Up to date!");
        }
    }

    private void UpdateLatestVerionLabel(string versionText)
    {
        InvokeSafe(lblLatestVersion, () =>
        {
            lblLatestVersion.Text = $"Latest Version: {versionText}";
        });
    }
    public void InvokeSafe(Control control, Action action)
    {
        if (control != null && !control.IsDisposed)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
    private bool IsCheckForUpdateRequired()
    {
        bool isUpdateRequired = false;
        string lastUpdateDate = _settings.LastCheckForUpdate;
        var lastUpdated = DateTime.Now;
        var today = DateTime.Now;
        DateTime.TryParseExact(lastUpdateDate, "MM-dd-yyyy", CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out lastUpdated);
        var diffOfDates = today - lastUpdated;
        //-- We only perform the check every two days. 
        if (diffOfDates.Days >= 2)
        {
            isUpdateRequired = true;
            _settings.LastCheckForUpdate = DateTime.Now.ToString("MM-dd-yyyy");
        }
        return isUpdateRequired;
    }
}
