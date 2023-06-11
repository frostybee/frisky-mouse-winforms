namespace FriskyMouse.UI.Controls
{
    partial class ClickDecorationControl
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
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            groupBox3 = new GroupBox();
            chkbColorTransition = new MaterialSkin.Controls.MaterialSwitch();
            cmbProfilesList = new MaterialSkin.Controls.MaterialComboBox();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            btnColorPicker = new Button();
            lblColor = new MaterialSkin.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            sliderAnimSpeed = new MaterialSkin.Controls.MaterialSlider();
            cmbInterpolationMode = new MaterialSkin.Controls.MaterialComboBox();
            cmbAnimDirection = new MaterialSkin.Controls.MaterialComboBox();
            switchEnableClicker = new MaterialSkin.Controls.MaterialSwitch();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            btnStopAnimation = new MaterialSkin.Controls.MaterialButton();
            btnPreview = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            pcbRipplePreview = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            materialLabel26.Size = new Size(208, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "Right Click Settings";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkbColorTransition);
            groupBox3.Controls.Add(cmbProfilesList);
            groupBox3.Controls.Add(sldRadius);
            groupBox3.Controls.Add(btnColorPicker);
            groupBox3.Controls.Add(lblColor);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(23, 56);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 130);
            groupBox3.TabIndex = 78;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ripple Profile Options";
            // 
            // chkbColorTransition
            // 
            chkbColorTransition.AutoSize = true;
            chkbColorTransition.Checked = true;
            chkbColorTransition.CheckState = CheckState.Checked;
            chkbColorTransition.Depth = 0;
            chkbColorTransition.Location = new Point(258, 31);
            chkbColorTransition.Margin = new Padding(0);
            chkbColorTransition.MouseLocation = new Point(-1, -1);
            chkbColorTransition.MouseState = MaterialSkin.MouseState.HOVER;
            chkbColorTransition.Name = "chkbColorTransition";
            chkbColorTransition.Ripple = true;
            chkbColorTransition.Size = new Size(167, 47);
            chkbColorTransition.TabIndex = 79;
            chkbColorTransition.Text = "Color Transition";
            chkbColorTransition.UseVisualStyleBackColor = true;
            // 
            // cmbProfilesList
            // 
            cmbProfilesList.AutoResize = false;
            cmbProfilesList.BackColor = Color.FromArgb(255, 255, 255);
            cmbProfilesList.Depth = 0;
            cmbProfilesList.DrawMode = DrawMode.OwnerDrawVariable;
            cmbProfilesList.DropDownHeight = 174;
            cmbProfilesList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfilesList.DropDownWidth = 121;
            cmbProfilesList.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbProfilesList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbProfilesList.FormattingEnabled = true;
            cmbProfilesList.Hint = "Select Profile:";
            cmbProfilesList.IntegralHeight = false;
            cmbProfilesList.ItemHeight = 43;
            cmbProfilesList.Location = new Point(13, 34);
            cmbProfilesList.Margin = new Padding(4);
            cmbProfilesList.MaxDropDownItems = 4;
            cmbProfilesList.MouseState = MaterialSkin.MouseState.OUT;
            cmbProfilesList.Name = "cmbProfilesList";
            cmbProfilesList.Size = new Size(218, 49);
            cmbProfilesList.StartIndex = 0;
            cmbProfilesList.TabIndex = 76;
            cmbProfilesList.UseAccent = false;
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            sldRadius.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(13, 87);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.Size = new Size(223, 40);
            sldRadius.TabIndex = 5;
            sldRadius.Text = "Radius  ";
            sldRadius.Value = 30;
            sldRadius.ValueSuffix = "px";
            // 
            // btnColorPicker
            // 
            btnColorPicker.FlatStyle = FlatStyle.Flat;
            btnColorPicker.Location = new Point(312, 87);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(76, 26);
            btnColorPicker.TabIndex = 12;
            btnColorPicker.Text = "...";
            btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Depth = 0;
            lblColor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblColor.Location = new Point(258, 94);
            lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(38, 19);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sliderAnimSpeed);
            groupBox2.Controls.Add(cmbInterpolationMode);
            groupBox2.Controls.Add(cmbAnimDirection);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(23, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 137);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Animation Options";
            // 
            // sliderAnimSpeed
            // 
            sliderAnimSpeed.Depth = 0;
            sliderAnimSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderAnimSpeed.Location = new Point(13, 29);
            sliderAnimSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderAnimSpeed.Name = "sliderAnimSpeed";
            sliderAnimSpeed.RangeMax = 80;
            sliderAnimSpeed.Size = new Size(223, 40);
            sliderAnimSpeed.TabIndex = 76;
            sliderAnimSpeed.Text = "Speed";
            sliderAnimSpeed.Value = 30;
            sliderAnimSpeed.ValueSuffix = "%";
            // 
            // cmbInterpolationMode
            // 
            cmbInterpolationMode.AutoResize = false;
            cmbInterpolationMode.BackColor = Color.FromArgb(255, 255, 255);
            cmbInterpolationMode.Depth = 0;
            cmbInterpolationMode.DrawMode = DrawMode.OwnerDrawVariable;
            cmbInterpolationMode.DropDownHeight = 174;
            cmbInterpolationMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterpolationMode.DropDownWidth = 121;
            cmbInterpolationMode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbInterpolationMode.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbInterpolationMode.FormattingEnabled = true;
            cmbInterpolationMode.Hint = "Interpolation";
            cmbInterpolationMode.ImeMode = ImeMode.Off;
            cmbInterpolationMode.IntegralHeight = false;
            cmbInterpolationMode.ItemHeight = 43;
            cmbInterpolationMode.Location = new Point(214, 78);
            cmbInterpolationMode.Margin = new Padding(4);
            cmbInterpolationMode.MaxDropDownItems = 4;
            cmbInterpolationMode.MouseState = MaterialSkin.MouseState.OUT;
            cmbInterpolationMode.Name = "cmbInterpolationMode";
            cmbInterpolationMode.Size = new Size(175, 49);
            cmbInterpolationMode.StartIndex = 0;
            cmbInterpolationMode.TabIndex = 77;
            cmbInterpolationMode.UseAccent = false;
            // 
            // cmbAnimDirection
            // 
            cmbAnimDirection.AutoResize = false;
            cmbAnimDirection.BackColor = Color.FromArgb(255, 255, 255);
            cmbAnimDirection.Depth = 0;
            cmbAnimDirection.DrawMode = DrawMode.OwnerDrawVariable;
            cmbAnimDirection.DropDownHeight = 174;
            cmbAnimDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnimDirection.DropDownWidth = 121;
            cmbAnimDirection.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbAnimDirection.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbAnimDirection.FormattingEnabled = true;
            cmbAnimDirection.Hint = "Direction";
            cmbAnimDirection.IntegralHeight = false;
            cmbAnimDirection.ItemHeight = 43;
            cmbAnimDirection.Location = new Point(13, 78);
            cmbAnimDirection.Margin = new Padding(4);
            cmbAnimDirection.MaxDropDownItems = 4;
            cmbAnimDirection.MouseState = MaterialSkin.MouseState.OUT;
            cmbAnimDirection.Name = "cmbAnimDirection";
            cmbAnimDirection.Size = new Size(175, 49);
            cmbAnimDirection.StartIndex = 0;
            cmbAnimDirection.TabIndex = 76;
            cmbAnimDirection.UseAccent = false;
            // 
            // switchEnableClicker
            // 
            switchEnableClicker.AutoSize = true;
            switchEnableClicker.Checked = true;
            switchEnableClicker.CheckState = CheckState.Checked;
            switchEnableClicker.Depth = 0;
            switchEnableClicker.Location = new Point(23, 11);
            switchEnableClicker.Margin = new Padding(0);
            switchEnableClicker.MouseLocation = new Point(-1, -1);
            switchEnableClicker.MouseState = MaterialSkin.MouseState.HOVER;
            switchEnableClicker.Name = "switchEnableClicker";
            switchEnableClicker.Ripple = true;
            switchEnableClicker.Size = new Size(243, 47);
            switchEnableClicker.TabIndex = 73;
            switchEnableClicker.Text = "Enable/Disable Decoration";
            switchEnableClicker.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(23, 338);
            sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            sldOutlineWidth.Name = "sldOutlineWidth";
            sldOutlineWidth.RangeMax = 10;
            sldOutlineWidth.RangeMin = 1;
            sldOutlineWidth.Size = new Size(220, 40);
            sldOutlineWidth.TabIndex = 15;
            sldOutlineWidth.Text = "Outline Thickness";
            sldOutlineWidth.Value = 1;
            sldOutlineWidth.ValueMax = 10;
            sldOutlineWidth.ValueSuffix = "px";
            // 
            // btnStopAnimation
            // 
            btnStopAnimation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStopAnimation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStopAnimation.Depth = 0;
            btnStopAnimation.HighEmphasis = true;
            btnStopAnimation.Icon = null;
            btnStopAnimation.Location = new Point(556, 312);
            btnStopAnimation.Margin = new Padding(4, 6, 4, 6);
            btnStopAnimation.MouseState = MaterialSkin.MouseState.HOVER;
            btnStopAnimation.Name = "btnStopAnimation";
            btnStopAnimation.NoAccentTextColor = Color.Empty;
            btnStopAnimation.Size = new Size(64, 36);
            btnStopAnimation.TabIndex = 10;
            btnStopAnimation.Text = "Stop";
            btnStopAnimation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStopAnimation.UseAccentColor = true;
            btnStopAnimation.UseVisualStyleBackColor = true;
            btnStopAnimation.Click += BtnStopAnimation_Click;
            // 
            // btnPreview
            // 
            btnPreview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPreview.Depth = 0;
            btnPreview.HighEmphasis = true;
            btnPreview.Icon = null;
            btnPreview.Location = new Point(628, 312);
            btnPreview.Margin = new Padding(4, 6, 4, 6);
            btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            btnPreview.Name = "btnPreview";
            btnPreview.NoAccentTextColor = Color.Empty;
            btnPreview.Size = new Size(83, 36);
            btnPreview.TabIndex = 9;
            btnPreview.Text = "Preview";
            btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPreview.UseAccentColor = false;
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += BtnPreview_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbRipplePreview);
            groupBox1.Location = new Point(481, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pcbRipplePreview
            // 
            pcbRipplePreview.BackColor = Color.White;
            pcbRipplePreview.Location = new Point(16, 28);
            pcbRipplePreview.Name = "pcbRipplePreview";
            pcbRipplePreview.Size = new Size(194, 178);
            pcbRipplePreview.TabIndex = 0;
            pcbRipplePreview.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer1.Size = new Size(813, 534);
            splitContainer1.SplitterDistance = 31;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(switchEnableClicker);
            panel1.Controls.Add(materialDivider1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnStopAnimation);
            panel1.Controls.Add(btnPreview);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(sldOutlineWidth);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 501);
            panel1.TabIndex = 3;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(23, 3);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(766, 2);
            materialDivider1.TabIndex = 77;
            materialDivider1.Text = "materialDivider1";
            // 
            // ClickDecorationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ClickDecorationControl";
            Size = new Size(829, 553);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch switchEnableClicker;
        private Button btnColorPicker;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialButton btnStopAnimation;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private GroupBox groupBox1;
        private PictureBox pcbRipplePreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialComboBox cmbAnimDirection;
        private MaterialSkin.Controls.MaterialComboBox cmbInterpolationMode;
        private MaterialSkin.Controls.MaterialSlider sliderAnimSpeed;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbProfilesList;
        private MaterialSkin.Controls.MaterialSwitch chkbColorTransition;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Panel panel1;
    }
}
