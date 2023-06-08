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
            components = new System.ComponentModel.Container();
            ToolStripMenuItem mnAbout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tbpHighlighter = new TabPage();
            _tabHighlighterSettings = new Controls.HighlighterControl();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            tbpClickDecorator = new TabPage();
            clickDecorationControl1 = new Controls.ClickDecorationControl();
            tbpSettings = new TabPage();
            settingsControl1 = new Controls.SettingsControl();
            tabAboutPage = new TabPage();
            aboutControl1 = new Source.UI.Controls.AboutControl();
            menuIconList = new ImageList(components);
            appNotifyIcon = new NotifyIcon(components);
            trayContextMenu = new ContextMenuStrip(components);
            mnShow = new ToolStripMenuItem();
            mnExit = new ToolStripMenuItem();
            mnAbout = new ToolStripMenuItem();
            mainTabControl.SuspendLayout();
            tbpHighlighter.SuspendLayout();
            tbpClickDecorator.SuspendLayout();
            tbpSettings.SuspendLayout();
            tabAboutPage.SuspendLayout();
            trayContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnAbout
            // 
            mnAbout.Name = "mnAbout";
            mnAbout.Size = new Size(119, 24);
            mnAbout.Text = "About";
            mnAbout.Click += MenuItemAbout_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tbpHighlighter);
            mainTabControl.Controls.Add(tbpClickDecorator);
            mainTabControl.Controls.Add(tbpSettings);
            mainTabControl.Controls.Add(tabAboutPage);
            mainTabControl.Depth = 0;
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.ImageList = menuIconList;
            mainTabControl.Location = new Point(4, 99);
            mainTabControl.Margin = new Padding(0);
            mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            mainTabControl.Multiline = true;
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1291, 841);
            mainTabControl.TabIndex = 0;
            // 
            // tbpHighlighter
            // 
            tbpHighlighter.BackColor = Color.White;
            tbpHighlighter.Controls.Add(_tabHighlighterSettings);
            tbpHighlighter.Controls.Add(materialDrawer1);
            tbpHighlighter.ImageKey = "spotlight-cursor-32.png";
            tbpHighlighter.Location = new Point(4, 31);
            tbpHighlighter.Margin = new Padding(3, 4, 3, 4);
            tbpHighlighter.Name = "tbpHighlighter";
            tbpHighlighter.Padding = new Padding(3, 4, 3, 4);
            tbpHighlighter.Size = new Size(1283, 806);
            tbpHighlighter.TabIndex = 0;
            tbpHighlighter.Text = "Highlighter";
            // 
            // _tabHighlighterSettings
            // 
            _tabHighlighterSettings.Location = new Point(0, 4);
            _tabHighlighterSettings.Margin = new Padding(3, 5, 3, 5);
            _tabHighlighterSettings.Name = "_tabHighlighterSettings";
            _tabHighlighterSettings.Size = new Size(930, 684);
            _tabHighlighterSettings.TabIndex = 2;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-8, 135);
            materialDrawer1.Margin = new Padding(3, 4, 3, 4);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(8, 10);
            materialDrawer1.TabIndex = 1;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // tbpClickDecorator
            // 
            tbpClickDecorator.BackColor = Color.White;
            tbpClickDecorator.Controls.Add(clickDecorationControl1);
            tbpClickDecorator.ImageKey = "left-click-50.png";
            tbpClickDecorator.Location = new Point(4, 31);
            tbpClickDecorator.Margin = new Padding(3, 4, 3, 4);
            tbpClickDecorator.Name = "tbpClickDecorator";
            tbpClickDecorator.Padding = new Padding(3, 4, 3, 4);
            tbpClickDecorator.Size = new Size(1283, 806);
            tbpClickDecorator.TabIndex = 1;
            tbpClickDecorator.Text = "Click Decorator";
            // 
            // clickDecorationControl1
            // 
            clickDecorationControl1.Location = new Point(1, 0);
            clickDecorationControl1.Margin = new Padding(3, 5, 3, 5);
            clickDecorationControl1.Name = "clickDecorationControl1";
            clickDecorationControl1.Size = new Size(927, 688);
            clickDecorationControl1.TabIndex = 0;
            // 
            // tbpSettings
            // 
            tbpSettings.BackColor = Color.White;
            tbpSettings.Controls.Add(settingsControl1);
            tbpSettings.ImageKey = "settings_24.png";
            tbpSettings.Location = new Point(4, 31);
            tbpSettings.Margin = new Padding(3, 4, 3, 4);
            tbpSettings.Name = "tbpSettings";
            tbpSettings.Padding = new Padding(3, 4, 3, 4);
            tbpSettings.Size = new Size(1283, 806);
            tbpSettings.TabIndex = 2;
            tbpSettings.Text = "Settings";
            // 
            // settingsControl1
            // 
            settingsControl1.Location = new Point(6, 8);
            settingsControl1.Margin = new Padding(3, 5, 3, 5);
            settingsControl1.Name = "settingsControl1";
            settingsControl1.Size = new Size(921, 588);
            settingsControl1.TabIndex = 0;
            // 
            // tabAboutPage
            // 
            tabAboutPage.BackColor = Color.White;
            tabAboutPage.Controls.Add(aboutControl1);
            tabAboutPage.Location = new Point(4, 31);
            tabAboutPage.Name = "tabAboutPage";
            tabAboutPage.Padding = new Padding(3);
            tabAboutPage.Size = new Size(1283, 806);
            tabAboutPage.TabIndex = 3;
            tabAboutPage.Text = "About";
            // 
            // aboutControl1
            // 
            aboutControl1.Location = new Point(6, 3);
            aboutControl1.Name = "aboutControl1";
            aboutControl1.Size = new Size(1274, 797);
            aboutControl1.TabIndex = 0;
            // 
            // menuIconList
            // 
            menuIconList.ColorDepth = ColorDepth.Depth32Bit;
            menuIconList.ImageStream = (ImageListStreamer)resources.GetObject("menuIconList.ImageStream");
            menuIconList.TransparentColor = Color.Transparent;
            menuIconList.Images.SetKeyName(0, "baseline_build_black_24dp.png");
            menuIconList.Images.SetKeyName(1, "baseline_favorite_border_black_24dp.png");
            menuIconList.Images.SetKeyName(2, "baseline_thumb_up_black_24dp.png");
            menuIconList.Images.SetKeyName(3, "minus.png");
            menuIconList.Images.SetKeyName(4, "round_add_black_24dp.png");
            menuIconList.Images.SetKeyName(5, "settings_24.png");
            menuIconList.Images.SetKeyName(6, "circle-cursor-32.png");
            menuIconList.Images.SetKeyName(7, "spotlight-cursor-32.png");
            menuIconList.Images.SetKeyName(8, "left-click-50.png");
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
            trayContextMenu.Size = new Size(120, 76);
            // 
            // mnShow
            // 
            mnShow.Name = "mnShow";
            mnShow.Size = new Size(119, 24);
            mnShow.Text = "Show";
            mnShow.Click += MenuItemShow_Click;
            // 
            // mnExit
            // 
            mnExit.Name = "mnExit";
            mnExit.Size = new Size(119, 24);
            mnExit.Text = "Exit";
            mnExit.Click += MenuItemExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1299, 945);
            Controls.Add(mainTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = mainTabControl;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Padding = new Padding(4, 99, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frisky Mouse";
            mainTabControl.ResumeLayout(false);
            tbpHighlighter.ResumeLayout(false);
            tbpClickDecorator.ResumeLayout(false);
            tbpSettings.ResumeLayout(false);
            tabAboutPage.ResumeLayout(false);
            trayContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private TabPage tbpHighlighter;
        private TabPage tbpClickDecorator;
        private ImageList menuIconList;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Controls.HighlighterControl _tabHighlighterSettings;
        private TabPage tbpSettings;
        private FriskyMouse.UI.Controls.SettingsControl settingsControl1;
        private NotifyIcon appNotifyIcon;
        private ContextMenuStrip trayContextMenu;
        private ToolStripMenuItem mnShow;
        private ToolStripMenuItem mnExit;
        private Controls.ClickDecorationControl clickDecorationControl1;
        private TabPage tabAboutPage;
        private Source.UI.Controls.AboutControl aboutControl1;
    }
}

