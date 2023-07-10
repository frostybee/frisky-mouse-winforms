#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be _disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolStripMenuItem mnAbout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabHighlighter = new TabPage();
            ctrlHighlighter = new Controls.HighlighterControl();
            materialDrawer = new MaterialSkin.Controls.MaterialDrawer();
            tabClickDecorator = new TabPage();
            ctrClickDecoration = new Controls.ClickIndicatorControl();
            tabRightClick = new TabPage();
            panel1 = new Panel();
            ctrLeftClickDecoration = new Controls.ClickIndicatorControl();
            tbpSettings = new TabPage();
            ctrlAppSettings = new Controls.AppSettingsControl();
            tabAboutPage = new TabPage();
            ctrlAbout = new Controls.AboutControl();
            menuIconList = new ImageList(components);
            appNotifyIcon = new NotifyIcon(components);
            trayContextMenu = new ContextMenuStrip(components);
            mnShow = new ToolStripMenuItem();
            mnExit = new ToolStripMenuItem();
            mnAbout = new ToolStripMenuItem();
            mainTabControl.SuspendLayout();
            tabHighlighter.SuspendLayout();
            tabClickDecorator.SuspendLayout();
            tabRightClick.SuspendLayout();
            panel1.SuspendLayout();
            tbpSettings.SuspendLayout();
            tabAboutPage.SuspendLayout();
            trayContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnAbout
            // 
            mnAbout.Image = Properties.Resources.about_50;
            mnAbout.Name = "mnAbout";
            mnAbout.Size = new Size(117, 26);
            mnAbout.Text = "About";
            mnAbout.Click += MenuItemAbout_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabHighlighter);
            mainTabControl.Controls.Add(tabClickDecorator);
            mainTabControl.Controls.Add(tabRightClick);
            mainTabControl.Controls.Add(tbpSettings);
            mainTabControl.Controls.Add(tabAboutPage);
            mainTabControl.Depth = 0;
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.ImageList = menuIconList;
            mainTabControl.Location = new Point(4, 74);
            mainTabControl.Margin = new Padding(0);
            mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            mainTabControl.Multiline = true;
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(671, 537);
            mainTabControl.TabIndex = 0;
            // 
            // tabHighlighter
            // 
            tabHighlighter.BackColor = Color.White;
            tabHighlighter.Controls.Add(ctrlHighlighter);
            tabHighlighter.Controls.Add(materialDrawer);
            tabHighlighter.ImageKey = "spotlight-cursor-32.png";
            tabHighlighter.Location = new Point(4, 31);
            tabHighlighter.Name = "tabHighlighter";
            tabHighlighter.Padding = new Padding(3);
            tabHighlighter.Size = new Size(663, 502);
            tabHighlighter.TabIndex = 0;
            tabHighlighter.Text = "Highlighter";
            // 
            // ctrlHighlighter
            // 
            ctrlHighlighter.Dock = DockStyle.Fill;
            ctrlHighlighter.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlHighlighter.Location = new Point(3, 3);
            ctrlHighlighter.Margin = new Padding(2, 3, 2, 3);
            ctrlHighlighter.Name = "ctrlHighlighter";
            ctrlHighlighter.Size = new Size(657, 496);
            ctrlHighlighter.TabIndex = 2;
            // 
            // materialDrawer
            // 
            materialDrawer.AutoHide = false;
            materialDrawer.AutoShow = false;
            materialDrawer.BackgroundWithAccent = false;
            materialDrawer.BaseTabControl = null;
            materialDrawer.Depth = 0;
            materialDrawer.HighlightWithAccent = true;
            materialDrawer.IndicatorWidth = 0;
            materialDrawer.IsOpen = false;
            materialDrawer.Location = new Point(-7, 101);
            materialDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer.Name = "materialDrawer";
            materialDrawer.ShowIconsWhenHidden = false;
            materialDrawer.Size = new Size(7, 8);
            materialDrawer.TabIndex = 1;
            materialDrawer.Text = "materialDrawer";
            materialDrawer.UseColors = false;
            // 
            // tabClickDecorator
            // 
            tabClickDecorator.BackColor = Color.White;
            tabClickDecorator.Controls.Add(ctrClickDecoration);
            tabClickDecorator.ImageKey = "left-click-50.png";
            tabClickDecorator.Location = new Point(4, 31);
            tabClickDecorator.Name = "tabClickDecorator";
            tabClickDecorator.Padding = new Padding(3);
            tabClickDecorator.Size = new Size(663, 502);
            tabClickDecorator.TabIndex = 1;
            tabClickDecorator.Text = "Left Click";
            // 
            // ctrClickDecoration
            // 
            ctrClickDecoration.Dock = DockStyle.Fill;
            ctrClickDecoration.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ctrClickDecoration.Location = new Point(3, 3);
            ctrClickDecoration.Margin = new Padding(0);
            ctrClickDecoration.Name = "ctrClickDecoration";
            ctrClickDecoration.Size = new Size(657, 496);
            ctrClickDecoration.TabIndex = 0;
            // 
            // tabRightClick
            // 
            tabRightClick.BackColor = Color.White;
            tabRightClick.Controls.Add(panel1);
            tabRightClick.ImageKey = "right-click-50.png";
            tabRightClick.Location = new Point(4, 31);
            tabRightClick.Name = "tabRightClick";
            tabRightClick.Padding = new Padding(3);
            tabRightClick.Size = new Size(663, 502);
            tabRightClick.TabIndex = 4;
            tabRightClick.Text = "Right Click";
            // 
            // panel1
            // 
            panel1.Controls.Add(ctrLeftClickDecoration);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 496);
            panel1.TabIndex = 0;
            // 
            // ctrLeftClickDecoration
            // 
            ctrLeftClickDecoration.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ctrLeftClickDecoration.Location = new Point(0, 1);
            ctrLeftClickDecoration.Name = "ctrLeftClickDecoration";
            ctrLeftClickDecoration.Size = new Size(831, 587);
            ctrLeftClickDecoration.TabIndex = 0;
            // 
            // tbpSettings
            // 
            tbpSettings.BackColor = Color.White;
            tbpSettings.Controls.Add(ctrlAppSettings);
            tbpSettings.ImageKey = "settings_24.png";
            tbpSettings.Location = new Point(4, 31);
            tbpSettings.Name = "tbpSettings";
            tbpSettings.Padding = new Padding(3);
            tbpSettings.Size = new Size(663, 502);
            tbpSettings.TabIndex = 2;
            tbpSettings.Text = "Settings";
            // 
            // ctrlAppSettings
            // 
            ctrlAppSettings.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlAppSettings.Location = new Point(0, 3);
            ctrlAppSettings.Name = "ctrlAppSettings";
            ctrlAppSettings.Size = new Size(732, 594);
            ctrlAppSettings.TabIndex = 0;
            // 
            // tabAboutPage
            // 
            tabAboutPage.BackColor = Color.White;
            tabAboutPage.Controls.Add(ctrlAbout);
            tabAboutPage.ImageKey = "about-50.png";
            tabAboutPage.Location = new Point(4, 31);
            tabAboutPage.Margin = new Padding(3, 2, 3, 2);
            tabAboutPage.Name = "tabAboutPage";
            tabAboutPage.Padding = new Padding(3, 2, 3, 2);
            tabAboutPage.Size = new Size(663, 502);
            tabAboutPage.TabIndex = 3;
            tabAboutPage.Text = "About";
            // 
            // ctrlAbout
            // 
            ctrlAbout.Dock = DockStyle.Fill;
            ctrlAbout.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlAbout.Location = new Point(3, 2);
            ctrlAbout.Margin = new Padding(0);
            ctrlAbout.Name = "ctrlAbout";
            ctrlAbout.Size = new Size(657, 498);
            ctrlAbout.TabIndex = 0;
            // 
            // menuIconList
            // 
            menuIconList.ColorDepth = ColorDepth.Depth32Bit;
            menuIconList.ImageStream = (ImageListStreamer)resources.GetObject("menuIconList.ImageStream");
            menuIconList.TransparentColor = Color.Transparent;
            menuIconList.Images.SetKeyName(0, "settings_24.png");
            menuIconList.Images.SetKeyName(1, "circle-cursor-32.png");
            menuIconList.Images.SetKeyName(2, "spotlight-cursor-32.png");
            menuIconList.Images.SetKeyName(3, "left-click-50.png");
            menuIconList.Images.SetKeyName(4, "about-50.png");
            menuIconList.Images.SetKeyName(5, "right-click-50.png");
            // 
            // appNotifyIcon
            // 
            appNotifyIcon.BalloonTipText = "Buzzing in progress!";
            appNotifyIcon.BalloonTipTitle = "Bee's mouse Decorator";
            appNotifyIcon.Icon = (Icon)resources.GetObject("appNotifyIcon.Icon");
            appNotifyIcon.Text = "Double click to open Mouse Decorator";
            appNotifyIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            trayContextMenu.ImageScalingSize = new Size(20, 20);
            trayContextMenu.Items.AddRange(new ToolStripItem[] { mnShow, mnAbout, mnExit });
            trayContextMenu.Name = "trayContextMenu";
            trayContextMenu.Size = new Size(118, 82);
            // 
            // mnShow
            // 
            mnShow.Image = Properties.Resources.show_app;
            mnShow.Name = "mnShow";
            mnShow.Size = new Size(117, 26);
            mnShow.Text = "Restore";
            mnShow.Click += MenuItemShow_Click;
            // 
            // mnExit
            // 
            mnExit.Image = Properties.Resources.close_64;
            mnExit.Name = "mnExit";
            mnExit.Size = new Size(117, 26);
            mnExit.Text = "Exit";
            mnExit.Click += MenuItemExit_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(679, 615);
            Controls.Add(mainTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = mainTabControl;
            Margin = new Padding(4);
            Name = "MainForm";
            Padding = new Padding(4, 74, 4, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frisky Mouse";
            mainTabControl.ResumeLayout(false);
            tabHighlighter.ResumeLayout(false);
            tabClickDecorator.ResumeLayout(false);
            tabRightClick.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tbpSettings.ResumeLayout(false);
            tabAboutPage.ResumeLayout(false);
            trayContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private TabPage tabHighlighter;
        private TabPage tabClickDecorator;
        private ImageList menuIconList;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer;
        private NotifyIcon appNotifyIcon;
        private ContextMenuStrip trayContextMenu;
        private ToolStripMenuItem mnShow;
        private ToolStripMenuItem mnExit;
        private Controls.ClickIndicatorControl ctrClickDecoration;
        private Controls.HighlighterControl ctrlHighlighter;
        private Controls.AboutControl ctrlAbout;
        private Controls.AppSettingsControl ctrlAppSettings;
        private TabPage tbpSettings;
        private TabPage tabAboutPage;
        private TabPage tabRightClick;
        private Panel panel1;
        private Controls.ClickIndicatorControl ctrLeftClickDecoration;
    }
}

