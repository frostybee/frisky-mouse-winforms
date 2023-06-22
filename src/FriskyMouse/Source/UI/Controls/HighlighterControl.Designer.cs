namespace FriskyMouse.UI.Controls
{
    partial class HighlighterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            colorDialog1 = new ColorDialog();
            switchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pboxPreview = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            switchFilledSpotlight = new MaterialSkin.Controls.MaterialSwitch();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            btnOutlineColorCk = new Button();
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            cmboxOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            btnResetSettings = new MaterialSkin.Controls.MaterialButton();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            switchShowOutline = new MaterialSkin.Controls.MaterialSwitch();
            switchShadow = new MaterialSkin.Controls.MaterialSwitch();
            btnOutlineColor = new MaterialSkin.Controls.MaterialButton();
            btnFillColor = new MaterialSkin.Controls.MaterialButton();
            btnFillColorBck = new Button();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            splitContainer1 = new SplitContainer();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // switchHighlighter
            // 
            switchHighlighter.AutoSize = true;
            switchHighlighter.Checked = true;
            switchHighlighter.CheckState = CheckState.Checked;
            switchHighlighter.Depth = 0;
            switchHighlighter.Location = new Point(229, 9);
            switchHighlighter.Margin = new Padding(0);
            switchHighlighter.MouseLocation = new Point(-1, -1);
            switchHighlighter.MouseState = MaterialSkin.MouseState.HOVER;
            switchHighlighter.Name = "switchHighlighter";
            switchHighlighter.Ripple = true;
            switchHighlighter.Size = new Size(74, 47);
            switchHighlighter.TabIndex = 73;
            switchHighlighter.Text = "On";
            switchHighlighter.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.Controls.Add(pboxPreview);
            materialCard1.Depth = 0;
            materialCard1.Elevation = 5;
            materialCard1.LargeTitle = false;
            materialCard1.Location = new Point(349, 120);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(5, 25, 5, 5);
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            materialCard1.ShadowBorder = graphicsPath1;
            materialCard1.Size = new Size(218, 217);
            materialCard1.TabIndex = 82;
            materialCard1.Title = null;
            // 
            // pboxPreview
            // 
            pboxPreview.Location = new Point(8, 6);
            pboxPreview.Margin = new Padding(2, 3, 2, 3);
            pboxPreview.Name = "pboxPreview";
            pboxPreview.Size = new Size(200, 200);
            pboxPreview.TabIndex = 0;
            pboxPreview.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(349, 74);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 81;
            materialLabel2.Text = "Preview";
            // 
            // sldOpacity
            // 
            sldOpacity.Depth = 0;
            sldOpacity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOpacity.Location = new Point(23, 89);
            sldOpacity.Margin = new Padding(2, 3, 2, 3);
            sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacity.Name = "sldOpacity";
            sldOpacity.RangeMax = 90;
            sldOpacity.Size = new Size(280, 40);
            sldOpacity.TabIndex = 4;
            sldOpacity.Text = "Opacity";
            sldOpacity.ValueSuffix = "%";
            // 
            // switchFilledSpotlight
            // 
            switchFilledSpotlight.AutoSize = true;
            switchFilledSpotlight.Checked = true;
            switchFilledSpotlight.CheckState = CheckState.Checked;
            switchFilledSpotlight.Depth = 0;
            switchFilledSpotlight.Location = new Point(25, 473);
            switchFilledSpotlight.Margin = new Padding(0);
            switchFilledSpotlight.MouseLocation = new Point(-1, -1);
            switchFilledSpotlight.MouseState = MaterialSkin.MouseState.HOVER;
            switchFilledSpotlight.Name = "switchFilledSpotlight";
            switchFilledSpotlight.Ripple = true;
            switchFilledSpotlight.Size = new Size(143, 47);
            switchFilledSpotlight.TabIndex = 14;
            switchFilledSpotlight.Text = "Filled Circle  ";
            switchFilledSpotlight.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(23, 303);
            sldOutlineWidth.Margin = new Padding(2, 3, 2, 3);
            sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            sldOutlineWidth.Name = "sldOutlineWidth";
            sldOutlineWidth.RangeMax = 10;
            sldOutlineWidth.RangeMin = 1;
            sldOutlineWidth.Size = new Size(280, 40);
            sldOutlineWidth.TabIndex = 15;
            sldOutlineWidth.Text = "Outline Width";
            sldOutlineWidth.Value = 1;
            sldOutlineWidth.ValueMax = 10;
            sldOutlineWidth.ValueSuffix = "px";
            // 
            // btnOutlineColorCk
            // 
            btnOutlineColorCk.FlatStyle = FlatStyle.Flat;
            btnOutlineColorCk.Location = new Point(125, 232);
            btnOutlineColorCk.Margin = new Padding(2, 3, 2, 3);
            btnOutlineColorCk.Name = "btnOutlineColorCk";
            btnOutlineColorCk.Size = new Size(70, 26);
            btnOutlineColorCk.TabIndex = 85;
            btnOutlineColorCk.Text = "...";
            btnOutlineColorCk.UseVisualStyleBackColor = true;
            btnOutlineColorCk.Click += BtnStrokeColor_Click;
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(477, 346);
            btnApplySettings.Margin = new Padding(4, 6, 4, 6);
            btnApplySettings.MouseState = MaterialSkin.MouseState.HOVER;
            btnApplySettings.Name = "btnApplySettings";
            btnApplySettings.NoAccentTextColor = Color.Empty;
            btnApplySettings.Size = new Size(67, 36);
            btnApplySettings.TabIndex = 9;
            btnApplySettings.Text = "Apply";
            btnApplySettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApplySettings.UseAccentColor = false;
            btnApplySettings.UseVisualStyleBackColor = true;
            btnApplySettings.Click += ApplySettings_Click;
            // 
            // cmboxOutlineStyle
            // 
            cmboxOutlineStyle.AutoResize = false;
            cmboxOutlineStyle.BackColor = Color.FromArgb(255, 255, 255);
            cmboxOutlineStyle.Depth = 0;
            cmboxOutlineStyle.DrawMode = DrawMode.OwnerDrawVariable;
            cmboxOutlineStyle.DropDownHeight = 174;
            cmboxOutlineStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxOutlineStyle.DropDownWidth = 121;
            cmboxOutlineStyle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmboxOutlineStyle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboxOutlineStyle.FormattingEnabled = true;
            cmboxOutlineStyle.Hint = "Outline style";
            cmboxOutlineStyle.IntegralHeight = false;
            cmboxOutlineStyle.ItemHeight = 43;
            cmboxOutlineStyle.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "Dash Dot", "Dash Dot Dot" });
            cmboxOutlineStyle.Location = new Point(23, 350);
            cmboxOutlineStyle.Margin = new Padding(4);
            cmboxOutlineStyle.MaxDropDownItems = 4;
            cmboxOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmboxOutlineStyle.Name = "cmboxOutlineStyle";
            cmboxOutlineStyle.Size = new Size(280, 49);
            cmboxOutlineStyle.StartIndex = 0;
            cmboxOutlineStyle.TabIndex = 72;
            cmboxOutlineStyle.UseAccent = false;
            // 
            // btnResetSettings
            // 
            btnResetSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnResetSettings.Depth = 0;
            btnResetSettings.HighEmphasis = true;
            btnResetSettings.Icon = null;
            btnResetSettings.Location = new Point(397, 346);
            btnResetSettings.Margin = new Padding(4, 6, 4, 6);
            btnResetSettings.MouseState = MaterialSkin.MouseState.HOVER;
            btnResetSettings.Name = "btnResetSettings";
            btnResetSettings.NoAccentTextColor = Color.Empty;
            btnResetSettings.Size = new Size(65, 36);
            btnResetSettings.TabIndex = 10;
            btnResetSettings.Text = "Reset";
            btnResetSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnResetSettings.UseAccentColor = true;
            btnResetSettings.UseVisualStyleBackColor = true;
            btnResetSettings.Click += ResetHighlighter_Click;
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(23, 130);
            sldRadius.Margin = new Padding(2, 3, 2, 3);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.Size = new Size(280, 40);
            sldRadius.TabIndex = 5;
            sldRadius.Text = "Radius  ";
            sldRadius.Value = 30;
            sldRadius.ValueSuffix = "px";
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel26.Location = new Point(23, 3);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(194, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "Cursor Highlighter";
            // 
            // panel1
            // 
            panel1.Controls.Add(switchShowOutline);
            panel1.Controls.Add(switchShadow);
            panel1.Controls.Add(btnOutlineColor);
            panel1.Controls.Add(btnFillColor);
            panel1.Controls.Add(btnFillColorBck);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(switchHighlighter);
            panel1.Controls.Add(sldOpacity);
            panel1.Controls.Add(switchFilledSpotlight);
            panel1.Controls.Add(sldRadius);
            panel1.Controls.Add(sldOutlineWidth);
            panel1.Controls.Add(btnResetSettings);
            panel1.Controls.Add(btnOutlineColorCk);
            panel1.Controls.Add(cmboxOutlineStyle);
            panel1.Controls.Add(btnApplySettings);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 667);
            panel1.TabIndex = 64;
            // 
            // switchShowOutline
            // 
            switchShowOutline.AutoSize = true;
            switchShowOutline.Checked = true;
            switchShowOutline.CheckState = CheckState.Checked;
            switchShowOutline.Depth = 0;
            switchShowOutline.Location = new Point(367, 473);
            switchShowOutline.Margin = new Padding(0);
            switchShowOutline.MouseLocation = new Point(-1, -1);
            switchShowOutline.MouseState = MaterialSkin.MouseState.HOVER;
            switchShowOutline.Name = "switchShowOutline";
            switchShowOutline.Ripple = true;
            switchShowOutline.Size = new Size(156, 47);
            switchShowOutline.TabIndex = 89;
            switchShowOutline.Text = "Show Outline  ";
            switchShowOutline.UseVisualStyleBackColor = true;
            // 
            // switchShadow
            // 
            switchShadow.AutoSize = true;
            switchShadow.Checked = true;
            switchShadow.CheckState = CheckState.Checked;
            switchShadow.Depth = 0;
            switchShadow.Location = new Point(195, 473);
            switchShadow.Margin = new Padding(0);
            switchShadow.MouseLocation = new Point(-1, -1);
            switchShadow.MouseState = MaterialSkin.MouseState.HOVER;
            switchShadow.Name = "switchShadow";
            switchShadow.Ripple = true;
            switchShadow.Size = new Size(116, 47);
            switchShadow.TabIndex = 88;
            switchShadow.Text = "Shadow ";
            switchShadow.UseVisualStyleBackColor = true;
            // 
            // btnOutlineColor
            // 
            btnOutlineColor.AutoSize = false;
            btnOutlineColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOutlineColor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnOutlineColor.Depth = 0;
            btnOutlineColor.HighEmphasis = false;
            btnOutlineColor.Icon = null;
            btnOutlineColor.Location = new Point(23, 227);
            btnOutlineColor.Margin = new Padding(4, 6, 4, 6);
            btnOutlineColor.MouseState = MaterialSkin.MouseState.HOVER;
            btnOutlineColor.Name = "btnOutlineColor";
            btnOutlineColor.NoAccentTextColor = Color.Empty;
            btnOutlineColor.Size = new Size(90, 36);
            btnOutlineColor.TabIndex = 87;
            btnOutlineColor.Text = "Outline";
            btnOutlineColor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOutlineColor.UseAccentColor = true;
            btnOutlineColor.UseVisualStyleBackColor = true;
            btnOutlineColor.Click += BtnStrokeColor_Click;
            // 
            // btnFillColor
            // 
            btnFillColor.AutoSize = false;
            btnFillColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFillColor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFillColor.Depth = 0;
            btnFillColor.HighEmphasis = true;
            btnFillColor.Icon = null;
            btnFillColor.Location = new Point(23, 179);
            btnFillColor.Margin = new Padding(4, 6, 4, 6);
            btnFillColor.MouseState = MaterialSkin.MouseState.HOVER;
            btnFillColor.Name = "btnFillColor";
            btnFillColor.NoAccentTextColor = Color.Empty;
            btnFillColor.Size = new Size(90, 36);
            btnFillColor.TabIndex = 78;
            btnFillColor.Text = "Fill";
            btnFillColor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFillColor.UseAccentColor = false;
            btnFillColor.UseVisualStyleBackColor = true;
            btnFillColor.Click += BtnFillColor_Click;
            // 
            // btnFillColorBck
            // 
            btnFillColorBck.FlatStyle = FlatStyle.Flat;
            btnFillColorBck.Location = new Point(125, 184);
            btnFillColorBck.Margin = new Padding(2, 3, 2, 3);
            btnFillColorBck.Name = "btnFillColorBck";
            btnFillColorBck.Size = new Size(70, 26);
            btnFillColorBck.TabIndex = 86;
            btnFillColorBck.Text = "...";
            btnFillColorBck.UseVisualStyleBackColor = true;
            btnFillColorBck.Click += BtnFillColor_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(23, 23);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(182, 19);
            materialLabel3.TabIndex = 81;
            materialLabel3.Text = "Enable Mouse Highlighter";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(23, 35);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(699, 2);
            materialDivider1.TabIndex = 76;
            materialDivider1.Text = "materialDivider1";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(materialDivider1);
            splitContainer1.Panel1.Controls.Add(materialLabel26);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1200, 726);
            splitContainer1.SplitterDistance = 55;
            splitContainer1.TabIndex = 65;
            // 
            // HighlighterControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "HighlighterControl";
            Size = new Size(1515, 1033);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private MaterialSkin.Controls.MaterialSwitch switchHighlighter;
        private MaterialSkin.Controls.MaterialComboBox cmboxOutlineStyle;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
        private MaterialSkin.Controls.MaterialSwitch switchFilledSpotlight;
        private Button btnOutlineColorCk;
        private MaterialSkin.Controls.MaterialButton btnResetSettings;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private MaterialSkin.Controls.MaterialSlider sldOpacity;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Button btnFillColorBck;
        private MaterialSkin.Controls.MaterialButton btnFillColor;
        private MaterialSkin.Controls.MaterialButton btnOutlineColor;
        private MaterialSkin.Controls.MaterialSwitch switchShadow;
        private MaterialSkin.Controls.MaterialSwitch switchShowOutline;
        //private Button Bt;
    }
}
