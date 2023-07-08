#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Core;
using FriskyMouse.Extensions;
using FriskyMouse.Settings;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace FriskyMouse.UI;

public partial class MainForm : MaterialForm
{
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly DecorationManager _decorationController;

    public MainForm()
    {
        //this.AutoScaleDimensions = new SizeF(10f, 13f);
        InitializeComponent();
        // Make the GUI ignore the DPI setting
        Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
        this.AutoScaleMode = AutoScaleMode.None;
        Size = new Size(757, 709);        
        // TODO: find the best value to auto-scale with.
        //Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);        
        DoubleBuffered = true;
        // Initialize the global managers.
        _decorationController = DecorationManager.Instance;
        _materialSkinManager = MaterialSkinManager.Instance;
        InitializeControls();
        //TopMost = true;
    }

    private void InitializeControls()
    {
        // Form's title.
        Text = "FriskyMouse";
        mainTabControl.SelectedIndex = 4;
        // Clean up resources on application exit.
        Application.ApplicationExit += Application_ApplicationExit;
        Icon = Properties.Resources.gaming_mouse_96;

        // Handle minimizing main application's window to the system tray.
        Resize += MainForm_Resize;

        appNotifyIcon.DoubleClick += AppNotifyIcon_DoubleClick;
        appNotifyIcon.Icon = Properties.Resources.gaming_mouse_96;
        appNotifyIcon.ContextMenuStrip = trayContextMenu;
        //-- Set up the form closing/loading events. They are required for ensuring that 
        // the mouse hooks is properly installed/uninstalled.
        Load += MainForm_Load;

        SetUpMaterialForm();
    }

    private void SetUpMaterialForm()
    {
        // Set this to false to disable backcolor enforcing on non-materialSkin components
        // This HAS to be set before the AddFormToManage()
        _materialSkinManager.EnforceBackcolorOnAllComponents = false;
        // MaterialSkinManager properties
        _materialSkinManager.AddFormToManage(this);
        /*_materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        _materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
            Primary.Indigo100, Accent.Pink200, TextShade.WHITE);*/
    }


    /// <summary>
    /// Minimizes the main application's window to the system tray.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Resize(object sender, EventArgs e)
    {
        if (FormWindowState.Minimized == this.WindowState)
        {
            appNotifyIcon.Visible = true;
            appNotifyIcon.ShowBalloonTip(300);
            ShowInTaskbar = false;
            this.Hide();
        }
        else if (FormWindowState.Normal == this.WindowState)
        {
            appNotifyIcon.Visible = false;
        }
    }

    /// <summary>
    /// Initializes the custom user controls of the mouse highlighter and click decorator features. 
    /// If both features are enabled, the mouse hook will be installed.
    /// The user settings will be loaded at this stage of the application.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            _decorationController.MainForm = this;
            _decorationController.BootstrapApp();
            ctrlHighlighter.UpdateControlsFromSettings();
            ctrClickDecoration.UpdateControlsFromSettings("Left Click Indicator", DecorationManager.Instance.ClickDecorator, SettingsManager.Settings.LeftClickOptions);
            ctrLeftClickDecoration.UpdateControlsFromSettings("Right Click Indicator ", DecorationManager.Instance.RightClickDecorator, SettingsManager.Settings.RightClickOptions);
            ctrlAppSettings.UpdateControlsFromSettings();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    /// <summary>
    /// Saves the mouse decoration settings upon shutting down the application. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Application_ApplicationExit(object sender, EventArgs e)
    {
        try
        {
            SettingsManager.SaveSettings();
            //appNotifyIcon?.Icon.Dispose();
            appNotifyIcon?.Dispose();
            _decorationController?.DisableHook();
            _decorationController?.Dispose();
            _materialSkinManager.Dispose();
        }
        catch (Exception)
        {
        }
    }

    /// <summary>
    /// Restores the main application's window from the system tray.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AppNotifyIcon_DoubleClick(object sender, EventArgs e)
    {
        Restore();
    }
    private void Restore()
    {
        Show();
        ShowInTaskbar = true;
        this.WindowState = FormWindowState.Normal;
        appNotifyIcon.Visible = false;
        bool oldTopMost = TopMost;
        TopMost = true;
        TopMost = false;
        BringToFront();
    }

    protected override void WndProc(ref Message inMessage)
    {
        if (inMessage.Msg == Program.WM_SHOW_MAIN_WINDOW)
        {
            Restore();
        }
        base.WndProc(ref inMessage);
    }

    private void MenuItemShow_Click(object sender, EventArgs e)
    {
        Restore();
    }

    private void MenuItemAbout_Click(object sender, EventArgs e)
    {
        mainTabControl.SelectedIndex = 4;
        Restore();
    }

    private void MenuItemExit_Click(object sender, EventArgs e)
    {
        Close();
        Application.Exit();
    }
}
