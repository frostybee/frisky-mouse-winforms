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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem mnAbout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpHighlighter = new System.Windows.Forms.TabPage();
            this._tabHighlighterSettings = new FriskyMouse.UI.Controls.HighlighterControl();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.tbpClickDecorator = new System.Windows.Forms.TabPage();
            this.clickDecorationControl1 = new FriskyMouse.UI.Controls.ClickDecorationControl();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.settingsControl1 = new FriskyMouse.UI.Controls.SettingsControl();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl.SuspendLayout();
            this.tbpHighlighter.SuspendLayout();
            this.tbpClickDecorator.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnAbout
            // 
            mnAbout.Name = "mnAbout";
            mnAbout.Size = new System.Drawing.Size(119, 24);
            mnAbout.Text = "About";
            mnAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tbpHighlighter);
            this.mainTabControl.Controls.Add(this.tbpClickDecorator);
            this.mainTabControl.Controls.Add(this.tbpSettings);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.menuIconList;
            this.mainTabControl.Location = new System.Drawing.Point(4, 79);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(941, 591);
            this.mainTabControl.TabIndex = 0;
            // 
            // tbpHighlighter
            // 
            this.tbpHighlighter.BackColor = System.Drawing.Color.White;
            this.tbpHighlighter.Controls.Add(this._tabHighlighterSettings);
            this.tbpHighlighter.Controls.Add(this.materialDrawer1);
            this.tbpHighlighter.ImageKey = "spotlight-cursor-32.png";
            this.tbpHighlighter.Location = new System.Drawing.Point(4, 31);
            this.tbpHighlighter.Name = "tbpHighlighter";
            this.tbpHighlighter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHighlighter.Size = new System.Drawing.Size(933, 556);
            this.tbpHighlighter.TabIndex = 0;
            this.tbpHighlighter.Text = "Highlighter";
            // 
            // _tabHighlighterSettings
            // 
            this._tabHighlighterSettings.Location = new System.Drawing.Point(0, 3);
            this._tabHighlighterSettings.Name = "_tabHighlighterSettings";
            this._tabHighlighterSettings.Size = new System.Drawing.Size(930, 547);
            this._tabHighlighterSettings.TabIndex = 2;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-8, 108);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(8, 8);
            this.materialDrawer1.TabIndex = 1;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // tbpClickDecorator
            // 
            this.tbpClickDecorator.BackColor = System.Drawing.Color.White;
            this.tbpClickDecorator.Controls.Add(this.clickDecorationControl1);
            this.tbpClickDecorator.ImageKey = "left-click-50.png";
            this.tbpClickDecorator.Location = new System.Drawing.Point(4, 31);
            this.tbpClickDecorator.Name = "tbpClickDecorator";
            this.tbpClickDecorator.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClickDecorator.Size = new System.Drawing.Size(933, 556);
            this.tbpClickDecorator.TabIndex = 1;
            this.tbpClickDecorator.Text = "Click Decorator";
            // 
            // clickDecorationControl1
            // 
            this.clickDecorationControl1.Location = new System.Drawing.Point(1, 0);
            this.clickDecorationControl1.Name = "clickDecorationControl1";
            this.clickDecorationControl1.Size = new System.Drawing.Size(927, 550);
            this.clickDecorationControl1.TabIndex = 0;
            // 
            // tbpSettings
            // 
            this.tbpSettings.BackColor = System.Drawing.Color.White;
            this.tbpSettings.Controls.Add(this.settingsControl1);
            this.tbpSettings.ImageKey = "settings_24.png";
            this.tbpSettings.Location = new System.Drawing.Point(4, 31);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(933, 556);
            this.tbpSettings.TabIndex = 2;
            this.tbpSettings.Text = "Settings";
            // 
            // settingsControl1
            // 
            this.settingsControl1.Location = new System.Drawing.Point(6, 6);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(921, 470);
            this.settingsControl1.TabIndex = 0;
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "baseline_build_black_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "baseline_favorite_border_black_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "baseline_thumb_up_black_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "minus.png");
            this.menuIconList.Images.SetKeyName(4, "round_add_black_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "settings_24.png");
            this.menuIconList.Images.SetKeyName(6, "circle-cursor-32.png");
            this.menuIconList.Images.SetKeyName(7, "spotlight-cursor-32.png");
            this.menuIconList.Images.SetKeyName(8, "left-click-50.png");
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.BalloonTipText = "Buzzing in progress!";
            this.appNotifyIcon.BalloonTipTitle = "Bee\'s mouse Decorator";
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "Double click to open Mouse Decorator";
            this.appNotifyIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnShow,
            mnAbout,
            this.mnExit});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(120, 76);
            // 
            // mnShow
            // 
            this.mnShow.Name = "mnShow";
            this.mnShow.Size = new System.Drawing.Size(119, 24);
            this.mnShow.Text = "Show";
            this.mnShow.Click += new System.EventHandler(this.MenuItemShow_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(119, 24);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 674);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frisky Mouse";
            this.mainTabControl.ResumeLayout(false);
            this.tbpHighlighter.ResumeLayout(false);
            this.tbpClickDecorator.ResumeLayout(false);
            this.tbpSettings.ResumeLayout(false);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tbpHighlighter;
        private System.Windows.Forms.TabPage tbpClickDecorator;
        private System.Windows.Forms.ImageList menuIconList;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Controls.HighlighterControl _tabHighlighterSettings;
        private System.Windows.Forms.TabPage tbpSettings;
        private FriskyMouse.UI.Controls.SettingsControl settingsControl1;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnShow;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private Controls.ClickDecorationControl clickDecorationControl1;
    }
}

