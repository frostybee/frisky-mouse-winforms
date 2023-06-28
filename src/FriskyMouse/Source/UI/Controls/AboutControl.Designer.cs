namespace FriskyMouse.UI.Controls
{
    partial class AboutControl
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
            GraphicsPath graphicsPath1 = new GraphicsPath();
            splitContainer1 = new SplitContainer();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            cmboxOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            btnResetSettings = new MaterialSkin.Controls.MaterialButton();
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            btnColorPicker = new Button();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            lblColor = new MaterialSkin.Controls.MaterialLabel();
            switchFilledSpotlight = new MaterialSkin.Controls.MaterialSwitch();
            sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pboxPreview = new PictureBox();
            grpOptions = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            grpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(materialLabel26);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grpOptions);
            splitContainer1.Size = new Size(892, 713);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 66;
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
            materialLabel26.Size = new Size(65, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "About";
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
            cmboxOutlineStyle.Location = new Point(14, 212);
            cmboxOutlineStyle.Margin = new Padding(4);
            cmboxOutlineStyle.MaxDropDownItems = 4;
            cmboxOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmboxOutlineStyle.Name = "cmboxOutlineStyle";
            cmboxOutlineStyle.Size = new Size(266, 49);
            cmboxOutlineStyle.StartIndex = 0;
            cmboxOutlineStyle.TabIndex = 72;
            cmboxOutlineStyle.UseAccent = false;
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(16, 59);
            sldRadius.Margin = new Padding(2, 3, 2, 3);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.Size = new Size(251, 40);
            sldRadius.TabIndex = 5;
            sldRadius.Text = "Radius  ";
            sldRadius.Value = 30;
            sldRadius.ValueSuffix = "px";
            // 
            // btnResetSettings
            // 
            btnResetSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnResetSettings.Depth = 0;
            btnResetSettings.HighEmphasis = true;
            btnResetSettings.Icon = null;
            btnResetSettings.Location = new Point(389, 274);
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
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(469, 274);
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
            // 
            // btnColorPicker
            // 
            btnColorPicker.FlatStyle = FlatStyle.Flat;
            btnColorPicker.Location = new Point(185, 121);
            btnColorPicker.Margin = new Padding(2, 3, 2, 3);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(70, 28);
            btnColorPicker.TabIndex = 12;
            btnColorPicker.Text = "...";
            btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(16, 165);
            sldOutlineWidth.Margin = new Padding(2, 3, 2, 3);
            sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            sldOutlineWidth.Name = "sldOutlineWidth";
            sldOutlineWidth.RangeMax = 10;
            sldOutlineWidth.RangeMin = 1;
            sldOutlineWidth.Size = new Size(251, 40);
            sldOutlineWidth.TabIndex = 15;
            sldOutlineWidth.Text = "Outline Thickness";
            sldOutlineWidth.Value = 1;
            sldOutlineWidth.ValueMax = 10;
            sldOutlineWidth.ValueSuffix = "px";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Depth = 0;
            lblColor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblColor.Location = new Point(188, 98);
            lblColor.Margin = new Padding(2, 0, 2, 0);
            lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(38, 19);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color";
            // 
            // switchFilledSpotlight
            // 
            switchFilledSpotlight.AutoSize = true;
            switchFilledSpotlight.Checked = true;
            switchFilledSpotlight.CheckState = CheckState.Checked;
            switchFilledSpotlight.Depth = 0;
            switchFilledSpotlight.Location = new Point(15, 101);
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
            // sldOpacity
            // 
            sldOpacity.Depth = 0;
            sldOpacity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOpacity.Location = new Point(16, 21);
            sldOpacity.Margin = new Padding(2, 3, 2, 3);
            sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacity.Name = "sldOpacity";
            sldOpacity.RangeMax = 90;
            sldOpacity.Size = new Size(247, 40);
            sldOpacity.TabIndex = 4;
            sldOpacity.Text = "Opacity";
            sldOpacity.ValueSuffix = "%";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(318, 17);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 81;
            materialLabel2.Text = "Preview";
            // 
            // materialCard1
            // 
            materialCard1.Controls.Add(pboxPreview);
            materialCard1.Depth = 0;
            materialCard1.Elevation = 5;
            materialCard1.LargeTitle = false;
            materialCard1.Location = new Point(319, 49);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(5, 25, 5, 5);
            graphicsPath1.FillMode = FillMode.Alternate;
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
            // grpOptions
            // 
            grpOptions.Controls.Add(materialCard1);
            grpOptions.Controls.Add(materialLabel2);
            grpOptions.Controls.Add(sldOpacity);
            grpOptions.Controls.Add(switchFilledSpotlight);
            grpOptions.Controls.Add(lblColor);
            grpOptions.Controls.Add(sldOutlineWidth);
            grpOptions.Controls.Add(btnColorPicker);
            grpOptions.Controls.Add(btnApplySettings);
            grpOptions.Controls.Add(cmboxOutlineStyle);
            grpOptions.Controls.Add(btnResetSettings);
            grpOptions.Controls.Add(sldRadius);
            grpOptions.Location = new Point(23, 18);
            grpOptions.Margin = new Padding(2);
            grpOptions.Name = "grpOptions";
            grpOptions.Padding = new Padding(2);
            grpOptions.Size = new Size(556, 329);
            grpOptions.TabIndex = 76;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AboutControl";
            Size = new Size(913, 768);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialComboBox cmboxOutlineStyle;
        private GroupBox grpOptions;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSlider sldOpacity;
        private MaterialSkin.Controls.MaterialSwitch switchFilledSpotlight;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
        private Button btnColorPicker;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
        private MaterialSkin.Controls.MaterialButton btnResetSettings;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
    }
}
