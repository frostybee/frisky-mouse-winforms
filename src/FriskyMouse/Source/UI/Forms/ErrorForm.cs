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

namespace FriskyMouse.UI;

public partial class ErrorForm : Form
{
    public bool IsUnhandledException { get; private set; }
    public string LogFilePath { get; private set; }
    public ErrorForm(Exception error, string bugReportPath) : this(error.Message, error.ToString())   {
    }

    public ErrorForm(string errorTitle, string errorMessage, bool unhandledException = true)
    {
        InitializeComponent();
        Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
        this.AutoScaleMode = AutoScaleMode.None;

        IsUnhandledException = unhandledException;

        lblErrorMessage.Text = errorTitle;
        txtException.Text = errorMessage;
        txtException.SelectionStart = txtException.TextLength;

        //btnSendBugReport.Visible = !string.IsNullOrEmpty(BugReportPath);        
        btnContinue.Visible = IsUnhandledException;
        btnClose.Visible = IsUnhandledException;
        btnOK.Visible = !IsUnhandledException;
    }

    private void ErrorForm_Shown(object sender, EventArgs e)
    {
        this.ForceActivate();
    }

    private void btnSendBugReport_Click(object sender, EventArgs e)
    {
        FMAppHelpers.OpenURL(FMAppLinks.GitHubIssuesURL);
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
        //DebugHelper.WriteLine("ShareX continue.");
        Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        Close();
    }
}
