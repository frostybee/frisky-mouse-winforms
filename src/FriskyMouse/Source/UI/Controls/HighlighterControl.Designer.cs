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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            colorDialog1 = new ColorDialog();
            panel2 = new Panel();
            grpOptions = new GroupBox();
            sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            cmboxOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            btnColorPicker = new Button();
            lblColor = new MaterialSkin.Controls.MaterialLabel();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            switchFilledSpotlight = new MaterialSkin.Controls.MaterialSwitch();
            switchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            label2 = new Label();
            groupBox1 = new GroupBox();
            pboxPreview = new PictureBox();
            btnResetSettings = new MaterialSkin.Controls.MaterialButton();
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            splitContainer1 = new SplitContainer();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            grpOptions.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(grpOptions);
            panel2.Controls.Add(switchHighlighter);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnResetSettings);
            panel2.Controls.Add(btnApplySettings);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 638);
            panel2.TabIndex = 61;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(sldOpacity);
            grpOptions.Controls.Add(sldRadius);
            grpOptions.Controls.Add(cmboxOutlineStyle);
            grpOptions.Controls.Add(btnColorPicker);
            grpOptions.Controls.Add(lblColor);
            grpOptions.Controls.Add(sldOutlineWidth);
            grpOptions.Controls.Add(switchFilledSpotlight);
            grpOptions.Location = new Point(26, 74);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(449, 303);
            grpOptions.TabIndex = 75;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // sldOpacity
            // 
            sldOpacity.Depth = 0;
            sldOpacity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOpacity.Location = new Point(15, 27);
            sldOpacity.Margin = new Padding(3, 4, 3, 4);
            sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacity.Name = "sldOpacity";
            sldOpacity.RangeMax = 90;
            sldOpacity.Size = new Size(255, 40);
            sldOpacity.TabIndex = 4;
            sldOpacity.Text = "Opacity";
            sldOpacity.ValueSuffix = "%";
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(15, 75);
            sldRadius.Margin = new Padding(3, 4, 3, 4);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.Size = new Size(255, 40);
            sldRadius.TabIndex = 5;
            sldRadius.Text = "Radius  ";
            sldRadius.Value = 30;
            sldRadius.ValueSuffix = "px";
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
            cmboxOutlineStyle.Location = new Point(15, 227);
            cmboxOutlineStyle.Margin = new Padding(5);
            cmboxOutlineStyle.MaxDropDownItems = 4;
            cmboxOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmboxOutlineStyle.Name = "cmboxOutlineStyle";
            cmboxOutlineStyle.Size = new Size(252, 49);
            cmboxOutlineStyle.StartIndex = 0;
            cmboxOutlineStyle.TabIndex = 72;
            cmboxOutlineStyle.UseAccent = false;
            // 
            // btnColorPicker
            // 
            btnColorPicker.FlatStyle = FlatStyle.Flat;
            btnColorPicker.Location = new Point(338, 67);
            btnColorPicker.Margin = new Padding(3, 4, 3, 4);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(87, 35);
            btnColorPicker.TabIndex = 12;
            btnColorPicker.Text = "...";
            btnColorPicker.UseVisualStyleBackColor = true;
            btnColorPicker.Click += ColorPicker_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Depth = 0;
            lblColor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblColor.Location = new Point(338, 40);
            lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(38, 19);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color";
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(15, 178);
            sldOutlineWidth.Margin = new Padding(3, 4, 3, 4);
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
            // switchFilledSpotlight
            // 
            switchFilledSpotlight.AutoSize = true;
            switchFilledSpotlight.Checked = true;
            switchFilledSpotlight.CheckState = CheckState.Checked;
            switchFilledSpotlight.Depth = 0;
            switchFilledSpotlight.Location = new Point(15, 137);
            switchFilledSpotlight.Margin = new Padding(0);
            switchFilledSpotlight.MouseLocation = new Point(-1, -1);
            switchFilledSpotlight.MouseState = MaterialSkin.MouseState.HOVER;
            switchFilledSpotlight.Name = "switchFilledSpotlight";
            switchFilledSpotlight.Ripple = true;
            switchFilledSpotlight.Size = new Size(139, 37);
            switchFilledSpotlight.TabIndex = 14;
            switchFilledSpotlight.Text = "Filled Circle";
            switchFilledSpotlight.UseVisualStyleBackColor = true;
            // 
            // switchHighlighter
            // 
            switchHighlighter.AutoSize = true;
            switchHighlighter.Checked = true;
            switchHighlighter.CheckState = CheckState.Checked;
            switchHighlighter.Depth = 0;
            switchHighlighter.Location = new Point(26, 11);
            switchHighlighter.Margin = new Padding(0);
            switchHighlighter.MouseLocation = new Point(-1, -1);
            switchHighlighter.MouseState = MaterialSkin.MouseState.HOVER;
            switchHighlighter.Name = "switchHighlighter";
            switchHighlighter.Ripple = true;
            switchHighlighter.Size = new Size(247, 37);
            switchHighlighter.TabIndex = 73;
            switchHighlighter.Text = "Enable/Disable Highlighter";
            switchHighlighter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(26, 0);
            label2.Name = "label2";
            label2.Size = new Size(750, 3);
            label2.TabIndex = 74;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pboxPreview);
            groupBox1.Location = new Point(493, 74);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(232, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pboxPreview
            // 
            pboxPreview.Location = new Point(14, 39);
            pboxPreview.Margin = new Padding(3, 4, 3, 4);
            pboxPreview.Name = "pboxPreview";
            pboxPreview.Size = new Size(203, 237);
            pboxPreview.TabIndex = 0;
            pboxPreview.TabStop = false;
            // 
            // btnResetSettings
            // 
            btnResetSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnResetSettings.Depth = 0;
            btnResetSettings.HighEmphasis = true;
            btnResetSettings.Icon = null;
            btnResetSettings.Location = new Point(583, 389);
            btnResetSettings.Margin = new Padding(5, 8, 5, 8);
            btnResetSettings.MouseState = MaterialSkin.MouseState.HOVER;
            btnResetSettings.Name = "btnResetSettings";
            btnResetSettings.NoAccentTextColor = Color.Empty;
            btnResetSettings.Size = new Size(65, 36);
            btnResetSettings.TabIndex = 10;
            btnResetSettings.Text = "Reset";
            btnResetSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnResetSettings.UseAccentColor = true;
            btnResetSettings.UseVisualStyleBackColor = true;
            btnResetSettings.Click += ResetSettings_Click;
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(658, 389);
            btnApplySettings.Margin = new Padding(5, 8, 5, 8);
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
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
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(830, 705);
            splitContainer1.SplitterDistance = 63;
            splitContainer1.TabIndex = 63;
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel26.Location = new Point(26, 7);
            materialLabel26.Margin = new Padding(5, 0, 5, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(306, 41);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = " Highlighter Settings";
            // 
            // HighlighterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HighlighterControl";
            Size = new Size(830, 705);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel panel2;
        private Label label2;
        private MaterialSkin.Controls.MaterialSwitch switchHighlighter;
        private MaterialSkin.Controls.MaterialComboBox cmboxOutlineStyle;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
        private MaterialSkin.Controls.MaterialSwitch switchFilledSpotlight;
        private Button btnColorPicker;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialButton btnResetSettings;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private MaterialSkin.Controls.MaterialSlider sldOpacity;
        private GroupBox groupBox1;
        private PictureBox pboxPreview;
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private GroupBox grpOptions;
    }
}
