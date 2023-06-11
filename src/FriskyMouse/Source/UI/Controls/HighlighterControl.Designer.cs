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
            switchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            grpOptions = new GroupBox();
            sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            cmboxOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            btnColorPicker = new Button();
            lblColor = new MaterialSkin.Controls.MaterialLabel();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            switchFilledSpotlight = new MaterialSkin.Controls.MaterialSwitch();
            groupBox1 = new GroupBox();
            pboxPreview = new PictureBox();
            btnResetSettings = new MaterialSkin.Controls.MaterialButton();
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            splitContainer1 = new SplitContainer();
            grpOptions.SuspendLayout();
            groupBox1.SuspendLayout();
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
            switchHighlighter.Location = new Point(251, 8);
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = SystemColors.Control;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(23, 22);
            materialLabel1.Margin = new Padding(2, 0, 2, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(182, 19);
            materialLabel1.TabIndex = 74;
            materialLabel1.Text = "Enable Mouse Highlighter";
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
            grpOptions.Location = new Point(23, 62);
            grpOptions.Margin = new Padding(2);
            grpOptions.Name = "grpOptions";
            grpOptions.Padding = new Padding(2);
            grpOptions.Size = new Size(315, 260);
            grpOptions.TabIndex = 75;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // sldOpacity
            // 
            sldOpacity.Depth = 0;
            sldOpacity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOpacity.Location = new Point(12, 22);
            sldOpacity.Margin = new Padding(2, 3, 2, 3);
            sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacity.Name = "sldOpacity";
            sldOpacity.RangeMax = 90;
            sldOpacity.Size = new Size(204, 40);
            sldOpacity.TabIndex = 4;
            sldOpacity.Text = "Opacity";
            sldOpacity.ValueSuffix = "%";
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(12, 60);
            sldRadius.Margin = new Padding(2, 3, 2, 3);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.Size = new Size(204, 40);
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
            cmboxOutlineStyle.Location = new Point(12, 189);
            cmboxOutlineStyle.Margin = new Padding(4);
            cmboxOutlineStyle.MaxDropDownItems = 4;
            cmboxOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmboxOutlineStyle.Name = "cmboxOutlineStyle";
            cmboxOutlineStyle.Size = new Size(202, 49);
            cmboxOutlineStyle.StartIndex = 0;
            cmboxOutlineStyle.TabIndex = 72;
            cmboxOutlineStyle.UseAccent = false;
            // 
            // btnColorPicker
            // 
            btnColorPicker.FlatStyle = FlatStyle.Flat;
            btnColorPicker.Location = new Point(234, 54);
            btnColorPicker.Margin = new Padding(2, 3, 2, 3);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(70, 28);
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
            lblColor.Location = new Point(234, 32);
            lblColor.Margin = new Padding(2, 0, 2, 0);
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
            sldOutlineWidth.Location = new Point(12, 143);
            sldOutlineWidth.Margin = new Padding(2, 3, 2, 3);
            sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            sldOutlineWidth.Name = "sldOutlineWidth";
            sldOutlineWidth.RangeMax = 10;
            sldOutlineWidth.RangeMin = 1;
            sldOutlineWidth.Size = new Size(201, 40);
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
            switchFilledSpotlight.Location = new Point(12, 110);
            switchFilledSpotlight.Margin = new Padding(0);
            switchFilledSpotlight.MouseLocation = new Point(-1, -1);
            switchFilledSpotlight.MouseState = MaterialSkin.MouseState.HOVER;
            switchFilledSpotlight.Name = "switchFilledSpotlight";
            switchFilledSpotlight.Ripple = true;
            switchFilledSpotlight.Size = new Size(135, 47);
            switchFilledSpotlight.TabIndex = 14;
            switchFilledSpotlight.Text = "Filled Circle";
            switchFilledSpotlight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pboxPreview);
            groupBox1.Location = new Point(346, 61);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(221, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pboxPreview
            // 
            pboxPreview.Location = new Point(11, 23);
            pboxPreview.Margin = new Padding(2, 3, 2, 3);
            pboxPreview.Name = "pboxPreview";
            pboxPreview.Size = new Size(200, 200);
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
            btnResetSettings.Location = new Point(392, 312);
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
            btnResetSettings.Click += ResetSettings_Click;
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(465, 312);
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
            panel1.Controls.Add(materialDivider1);
            panel1.Controls.Add(switchHighlighter);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(grpOptions);
            panel1.Controls.Add(btnApplySettings);
            panel1.Controls.Add(btnResetSettings);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 564);
            panel1.TabIndex = 64;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(23, 1);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(699, 3);
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
            splitContainer1.Panel1.Controls.Add(materialLabel26);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(718, 600);
            splitContainer1.SplitterDistance = 32;
            splitContainer1.TabIndex = 65;
            // 
            // HighlighterControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "HighlighterControl";
            Size = new Size(752, 625);
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Button btnColorPicker;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialButton btnResetSettings;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private MaterialSkin.Controls.MaterialSlider sldOpacity;
        private GroupBox groupBox1;
        private PictureBox pboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private GroupBox grpOptions;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
