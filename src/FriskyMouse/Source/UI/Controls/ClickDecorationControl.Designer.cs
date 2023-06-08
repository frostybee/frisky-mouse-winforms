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
            label1 = new Label();
            groupBox1 = new GroupBox();
            pcbRipplePreview = new PictureBox();
            splitContainer1 = new SplitContainer();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel26.Location = new Point(26, 10);
            materialLabel26.Margin = new Padding(5, 0, 5, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(292, 41);
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
            groupBox3.Location = new Point(26, 94);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(504, 195);
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
            chkbColorTransition.Location = new Point(295, 41);
            chkbColorTransition.Margin = new Padding(0);
            chkbColorTransition.MouseLocation = new Point(-1, -1);
            chkbColorTransition.MouseState = MaterialSkin.MouseState.HOVER;
            chkbColorTransition.Name = "chkbColorTransition";
            chkbColorTransition.Ripple = true;
            chkbColorTransition.Size = new Size(171, 37);
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
            cmbProfilesList.Location = new Point(15, 45);
            cmbProfilesList.Margin = new Padding(5);
            cmbProfilesList.MaxDropDownItems = 4;
            cmbProfilesList.MouseState = MaterialSkin.MouseState.OUT;
            cmbProfilesList.Name = "cmbProfilesList";
            cmbProfilesList.Size = new Size(249, 49);
            cmbProfilesList.StartIndex = 0;
            cmbProfilesList.TabIndex = 76;
            cmbProfilesList.UseAccent = false;
            // 
            // sldRadius
            // 
            sldRadius.Depth = 0;
            sldRadius.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadius.Location = new Point(15, 116);
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
            // btnColorPicker
            // 
            btnColorPicker.FlatStyle = FlatStyle.Flat;
            btnColorPicker.Location = new Point(357, 116);
            btnColorPicker.Margin = new Padding(3, 4, 3, 4);
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.Size = new Size(87, 35);
            btnColorPicker.TabIndex = 12;
            btnColorPicker.Text = "...";
            btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Depth = 0;
            lblColor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblColor.Location = new Point(295, 126);
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
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(26, 306);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(504, 195);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Animation Options";
            // 
            // sliderAnimSpeed
            // 
            sliderAnimSpeed.Depth = 0;
            sliderAnimSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderAnimSpeed.Location = new Point(15, 39);
            sliderAnimSpeed.Margin = new Padding(3, 4, 3, 4);
            sliderAnimSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderAnimSpeed.Name = "sliderAnimSpeed";
            sliderAnimSpeed.RangeMax = 80;
            sliderAnimSpeed.Size = new Size(255, 40);
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
            cmbInterpolationMode.Location = new Point(245, 104);
            cmbInterpolationMode.Margin = new Padding(5);
            cmbInterpolationMode.MaxDropDownItems = 4;
            cmbInterpolationMode.MouseState = MaterialSkin.MouseState.OUT;
            cmbInterpolationMode.Name = "cmbInterpolationMode";
            cmbInterpolationMode.Size = new Size(199, 49);
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
            cmbAnimDirection.Location = new Point(15, 104);
            cmbAnimDirection.Margin = new Padding(5);
            cmbAnimDirection.MaxDropDownItems = 4;
            cmbAnimDirection.MouseState = MaterialSkin.MouseState.OUT;
            cmbAnimDirection.Name = "cmbAnimDirection";
            cmbAnimDirection.Size = new Size(199, 49);
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
            switchEnableClicker.Location = new Point(26, 24);
            switchEnableClicker.Margin = new Padding(0);
            switchEnableClicker.MouseLocation = new Point(-1, -1);
            switchEnableClicker.MouseState = MaterialSkin.MouseState.HOVER;
            switchEnableClicker.Name = "switchEnableClicker";
            switchEnableClicker.Ripple = true;
            switchEnableClicker.Size = new Size(247, 37);
            switchEnableClicker.TabIndex = 73;
            switchEnableClicker.Text = "Enable/Disable Decoration";
            switchEnableClicker.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(41, 509);
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
            // btnStopAnimation
            // 
            btnStopAnimation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStopAnimation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStopAnimation.Depth = 0;
            btnStopAnimation.HighEmphasis = true;
            btnStopAnimation.Icon = null;
            btnStopAnimation.Location = new Point(663, 405);
            btnStopAnimation.Margin = new Padding(5, 8, 5, 8);
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
            btnPreview.Location = new Point(737, 405);
            btnPreview.Margin = new Padding(5, 8, 5, 8);
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(26, 11);
            label1.Name = "label1";
            label1.Size = new Size(750, 3);
            label1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbRipplePreview);
            groupBox1.Location = new Point(557, 94);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(263, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pcbRipplePreview
            // 
            pcbRipplePreview.BackColor = Color.White;
            pcbRipplePreview.Location = new Point(18, 37);
            pcbRipplePreview.Margin = new Padding(3, 4, 3, 4);
            pcbRipplePreview.Name = "pcbRipplePreview";
            pcbRipplePreview.Size = new Size(222, 237);
            pcbRipplePreview.TabIndex = 0;
            pcbRipplePreview.TabStop = false;
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
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(btnStopAnimation);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(sldOutlineWidth);
            splitContainer1.Panel2.Controls.Add(btnPreview);
            splitContainer1.Panel2.Controls.Add(switchEnableClicker);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(905, 801);
            splitContainer1.SplitterDistance = 57;
            splitContainer1.TabIndex = 2;
            // 
            // ClickDecorationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClickDecorationControl";
            Size = new Size(905, 801);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch switchEnableClicker;
        private Button btnColorPicker;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialButton btnStopAnimation;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private Label label1;
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
    }
}
