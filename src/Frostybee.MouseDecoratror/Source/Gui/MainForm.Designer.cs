namespace Frostybee.MouseDecorator
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpHighlighter = new System.Windows.Forms.TabPage();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.tbpClickDecorator = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabHighlighterSettings = new Frostybee.MouseDecorator.Controls.HighlighterControl();
            this.settingsControl1 = new Frostybee.MouseDecorator.Source.Gui.Controls.SettingsControl();
            this.mainTabControl.SuspendLayout();
            this.tbpHighlighter.SuspendLayout();
            this.tbpClickDecorator.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.SuspendLayout();
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
            this.tbpHighlighter.Controls.Add(this.tabHighlighterSettings);
            this.tbpHighlighter.Controls.Add(this.materialDrawer1);
            this.tbpHighlighter.ImageKey = "round_assessment_white_24dp.png";
            this.tbpHighlighter.Location = new System.Drawing.Point(4, 31);
            this.tbpHighlighter.Name = "tbpHighlighter";
            this.tbpHighlighter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHighlighter.Size = new System.Drawing.Size(933, 556);
            this.tbpHighlighter.TabIndex = 0;
            this.tbpHighlighter.Text = "Home";
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
            this.tbpClickDecorator.Controls.Add(this.materialCard1);
            this.tbpClickDecorator.Location = new System.Drawing.Point(4, 31);
            this.tbpClickDecorator.Name = "tbpClickDecorator";
            this.tbpClickDecorator.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClickDecorator.Size = new System.Drawing.Size(933, 556);
            this.tbpClickDecorator.TabIndex = 1;
            this.tbpClickDecorator.Text = "Click Decorator";
            // 
            // materialCard1
            // 
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Elevation = 5;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.LargeTitle = false;
            this.materialCard1.Location = new System.Drawing.Point(17, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialCard1.ShadowBorder = graphicsPath1;
            this.materialCard1.Size = new System.Drawing.Size(668, 164);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Title = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(163, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Click decoration effect:";
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
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "baseline_bluetooth_black_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "baseline_build_black_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "baseline_favorite_border_black_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "baseline_fingerprint_black_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "baseline_thumb_up_black_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "minus.png");
            this.menuIconList.Images.SetKeyName(6, "plus.png");
            this.menuIconList.Images.SetKeyName(7, "round_add_black_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(10, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(11, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(12, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(13, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(14, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(15, "round_phone_black_24dp.png");
            this.menuIconList.Images.SetKeyName(16, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(17, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(18, "settings_24.png");
            // 
            // tabHighlighterSettings
            // 
            this.tabHighlighterSettings.Location = new System.Drawing.Point(0, 3);
            this.tabHighlighterSettings.Name = "tabHighlighterSettings";
            this.tabHighlighterSettings.Size = new System.Drawing.Size(930, 547);
            this.tabHighlighterSettings.TabIndex = 2;
            // 
            // settingsControl1
            // 
            this.settingsControl1.Location = new System.Drawing.Point(6, 6);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(921, 470);
            this.settingsControl1.TabIndex = 0;
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
            this.Text = "Mouse Decorator Settings UI";
            this.mainTabControl.ResumeLayout(false);
            this.tbpHighlighter.ResumeLayout(false);
            this.tbpClickDecorator.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tbpSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tbpHighlighter;
        private System.Windows.Forms.TabPage tbpClickDecorator;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ImageList menuIconList;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Controls.HighlighterControl tabHighlighterSettings;
        private System.Windows.Forms.TabPage tbpSettings;
        private Source.Gui.Controls.SettingsControl settingsControl1;
    }
}

