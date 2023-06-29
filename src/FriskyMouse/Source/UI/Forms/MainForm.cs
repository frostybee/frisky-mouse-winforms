#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.Core;
using FriskyMouse.Settings;
using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FriskyMouse.UI
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly DecorationManager _decorationController;

        public MainForm()
        {
            InitializeComponent();
            // TODO: find the best value to auto-scale with.
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96f, 96f);
            DoubleBuffered = true;
            // Initialize the global managers.
            _decorationController = DecorationManager.Instance;
            _materialSkinManager = MaterialSkinManager.Instance;
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Form's title.
            Text = "Frisky Mouse";

            mainTabControl.SelectedIndex = 1;
            // Clean up resources on application exit.
            Application.ApplicationExit += Application_ApplicationExit;
            this.Icon = Properties.Resources.bee_icon;

            // Handle minimizing main application's window to the system tray.
            this.Resize += MainForm_Resize;

            appNotifyIcon.DoubleClick += AppNotifyIcon_DoubleClick;
            appNotifyIcon.Icon = Properties.Resources.bee_icon;
            appNotifyIcon.ContextMenuStrip = trayContextMenu;
            //-- Set up the form closing/loading events. They are required for ensuring that 
            // the mouse hooks is properly installed/uninstalled.
            this.Load += MainForm_Load;

            SetUpMaterialForm();
        }

        private void SetUpMaterialForm()
        {
            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            _materialSkinManager.EnforceBackcolorOnAllComponents = false;
            // MaterialSkinManager properties
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
                Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
                ctrClickDecoration.UpdateControlsFromSettings("Left Click Decoration", DecorationManager.Instance.ClickDecorator, SettingsManager.Settings.LeftClickOptions);
                ctrLeftClickDecoration.UpdateControlsFromSettings("Right Click Decoration", DecorationManager.Instance.RightClickDecorator, SettingsManager.Settings.RightClickOptions);
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
            // Show the about page. Focus the about tab.
            //MessageBox.Show("About page!");
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
