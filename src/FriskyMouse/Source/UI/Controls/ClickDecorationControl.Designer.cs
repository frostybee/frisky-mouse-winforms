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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkbColorTransition = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbProfilesList = new MaterialSkin.Controls.MaterialComboBox();
            this.sldRadius = new MaterialSkin.Controls.MaterialSlider();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.lblColor = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sliderAnimSpeed = new MaterialSkin.Controls.MaterialSlider();
            this.cmbInterpolationMode = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbAnimDirection = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.switchEnableClicker = new MaterialSkin.Controls.MaterialSwitch();
            this.sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            this.btnStopAnimation = new MaterialSkin.Controls.MaterialButton();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbRipplePreview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRipplePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel26);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 584);
            this.panel1.TabIndex = 1;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel26.Location = new System.Drawing.Point(4, 0);
            this.materialLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(292, 41);
            this.materialLabel26.TabIndex = 62;
            this.materialLabel26.Text = "Right Click Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.switchEnableClicker);
            this.panel2.Controls.Add(this.sldOutlineWidth);
            this.panel2.Controls.Add(this.btnStopAnimation);
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(11, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 499);
            this.panel2.TabIndex = 61;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbColorTransition);
            this.groupBox3.Controls.Add(this.cmbProfilesList);
            this.groupBox3.Controls.Add(this.sldRadius);
            this.groupBox3.Controls.Add(this.btnColorPicker);
            this.groupBox3.Controls.Add(this.lblColor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 155);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ripple Profile Options";
            // 
            // chkbColorTransition
            // 
            this.chkbColorTransition.AutoSize = true;
            this.chkbColorTransition.Checked = true;
            this.chkbColorTransition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbColorTransition.Depth = 0;
            this.chkbColorTransition.Location = new System.Drawing.Point(273, 37);
            this.chkbColorTransition.Margin = new System.Windows.Forms.Padding(0);
            this.chkbColorTransition.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbColorTransition.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbColorTransition.Name = "chkbColorTransition";
            this.chkbColorTransition.Ripple = true;
            this.chkbColorTransition.Size = new System.Drawing.Size(171, 37);
            this.chkbColorTransition.TabIndex = 79;
            this.chkbColorTransition.Text = "Color Transition";
            this.chkbColorTransition.UseVisualStyleBackColor = true;
            // 
            // cmbProfilesList
            // 
            this.cmbProfilesList.AutoResize = false;
            this.cmbProfilesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProfilesList.Depth = 0;
            this.cmbProfilesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProfilesList.DropDownHeight = 174;
            this.cmbProfilesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfilesList.DropDownWidth = 121;
            this.cmbProfilesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmbProfilesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbProfilesList.FormattingEnabled = true;
            this.cmbProfilesList.Hint = "Select Profile:";
            this.cmbProfilesList.IntegralHeight = false;
            this.cmbProfilesList.ItemHeight = 43;
            this.cmbProfilesList.Location = new System.Drawing.Point(7, 37);
            this.cmbProfilesList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProfilesList.MaxDropDownItems = 4;
            this.cmbProfilesList.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProfilesList.Name = "cmbProfilesList";
            this.cmbProfilesList.Size = new System.Drawing.Size(248, 49);
            this.cmbProfilesList.StartIndex = 0;
            this.cmbProfilesList.TabIndex = 76;
            this.cmbProfilesList.UseAccent = false;
            // 
            // sldRadius
            // 
            this.sldRadius.Depth = 0;
            this.sldRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldRadius.Location = new System.Drawing.Point(6, 93);
            this.sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldRadius.Name = "sldRadius";
            this.sldRadius.RangeMax = 80;
            this.sldRadius.Size = new System.Drawing.Size(255, 40);
            this.sldRadius.TabIndex = 5;
            this.sldRadius.Text = "Radius  ";
            this.sldRadius.Value = 30;
            this.sldRadius.ValueSuffix = "px";
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPicker.Location = new System.Drawing.Point(357, 93);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(87, 27);
            this.btnColorPicker.TabIndex = 12;
            this.btnColorPicker.Text = "...";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Depth = 0;
            this.lblColor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblColor.Location = new System.Drawing.Point(281, 98);
            this.lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(38, 19);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sliderAnimSpeed);
            this.groupBox2.Controls.Add(this.cmbInterpolationMode);
            this.groupBox2.Controls.Add(this.cmbAnimDirection);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 155);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation Options";
            // 
            // sliderAnimSpeed
            // 
            this.sliderAnimSpeed.Depth = 0;
            this.sliderAnimSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderAnimSpeed.Location = new System.Drawing.Point(7, 31);
            this.sliderAnimSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderAnimSpeed.Name = "sliderAnimSpeed";
            this.sliderAnimSpeed.RangeMax = 80;
            this.sliderAnimSpeed.Size = new System.Drawing.Size(255, 40);
            this.sliderAnimSpeed.TabIndex = 76;
            this.sliderAnimSpeed.Text = "Speed";
            this.sliderAnimSpeed.Value = 30;
            this.sliderAnimSpeed.ValueSuffix = "%";
            // 
            // cmbInterpolationMode
            // 
            this.cmbInterpolationMode.AutoResize = false;
            this.cmbInterpolationMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbInterpolationMode.Depth = 0;
            this.cmbInterpolationMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbInterpolationMode.DropDownHeight = 174;
            this.cmbInterpolationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterpolationMode.DropDownWidth = 121;
            this.cmbInterpolationMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmbInterpolationMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInterpolationMode.FormattingEnabled = true;
            this.cmbInterpolationMode.Hint = "Interpolation";
            this.cmbInterpolationMode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbInterpolationMode.IntegralHeight = false;
            this.cmbInterpolationMode.ItemHeight = 43;
            this.cmbInterpolationMode.Location = new System.Drawing.Point(235, 83);
            this.cmbInterpolationMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInterpolationMode.MaxDropDownItems = 4;
            this.cmbInterpolationMode.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbInterpolationMode.Name = "cmbInterpolationMode";
            this.cmbInterpolationMode.Size = new System.Drawing.Size(199, 49);
            this.cmbInterpolationMode.StartIndex = 0;
            this.cmbInterpolationMode.TabIndex = 77;
            this.cmbInterpolationMode.UseAccent = false;
            // 
            // cmbAnimDirection
            // 
            this.cmbAnimDirection.AutoResize = false;
            this.cmbAnimDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAnimDirection.Depth = 0;
            this.cmbAnimDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAnimDirection.DropDownHeight = 174;
            this.cmbAnimDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimDirection.DropDownWidth = 121;
            this.cmbAnimDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmbAnimDirection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAnimDirection.FormattingEnabled = true;
            this.cmbAnimDirection.Hint = "Direction";
            this.cmbAnimDirection.IntegralHeight = false;
            this.cmbAnimDirection.ItemHeight = 43;
            this.cmbAnimDirection.Location = new System.Drawing.Point(7, 83);
            this.cmbAnimDirection.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnimDirection.MaxDropDownItems = 4;
            this.cmbAnimDirection.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAnimDirection.Name = "cmbAnimDirection";
            this.cmbAnimDirection.Size = new System.Drawing.Size(199, 49);
            this.cmbAnimDirection.StartIndex = 0;
            this.cmbAnimDirection.TabIndex = 76;
            this.cmbAnimDirection.UseAccent = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(698, 2);
            this.label2.TabIndex = 74;
            // 
            // switchEnableClicker
            // 
            this.switchEnableClicker.AutoSize = true;
            this.switchEnableClicker.Checked = true;
            this.switchEnableClicker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchEnableClicker.Depth = 0;
            this.switchEnableClicker.Location = new System.Drawing.Point(12, 7);
            this.switchEnableClicker.Margin = new System.Windows.Forms.Padding(0);
            this.switchEnableClicker.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchEnableClicker.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchEnableClicker.Name = "switchEnableClicker";
            this.switchEnableClicker.Ripple = true;
            this.switchEnableClicker.Size = new System.Drawing.Size(247, 37);
            this.switchEnableClicker.TabIndex = 73;
            this.switchEnableClicker.Text = "Enable/Disable Decoration";
            this.switchEnableClicker.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            this.sldOutlineWidth.Depth = 0;
            this.sldOutlineWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldOutlineWidth.Location = new System.Drawing.Point(12, 414);
            this.sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldOutlineWidth.Name = "sldOutlineWidth";
            this.sldOutlineWidth.RangeMax = 10;
            this.sldOutlineWidth.RangeMin = 1;
            this.sldOutlineWidth.Size = new System.Drawing.Size(252, 40);
            this.sldOutlineWidth.TabIndex = 15;
            this.sldOutlineWidth.Text = "Outline Thickness";
            this.sldOutlineWidth.Value = 1;
            this.sldOutlineWidth.ValueMax = 10;
            this.sldOutlineWidth.ValueSuffix = "px";
            // 
            // btnStopAnimation
            // 
            this.btnStopAnimation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStopAnimation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStopAnimation.Depth = 0;
            this.btnStopAnimation.HighEmphasis = true;
            this.btnStopAnimation.Icon = null;
            this.btnStopAnimation.Location = new System.Drawing.Point(609, 360);
            this.btnStopAnimation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStopAnimation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStopAnimation.Name = "btnStopAnimation";
            this.btnStopAnimation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStopAnimation.Size = new System.Drawing.Size(64, 36);
            this.btnStopAnimation.TabIndex = 10;
            this.btnStopAnimation.Text = "Stop";
            this.btnStopAnimation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStopAnimation.UseAccentColor = true;
            this.btnStopAnimation.UseVisualStyleBackColor = true;
            this.btnStopAnimation.Click += new System.EventHandler(this.BtnStopAnimation_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new System.Drawing.Point(517, 360);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreview.Size = new System.Drawing.Size(83, 36);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 2);
            this.label1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbRipplePreview);
            this.groupBox1.Location = new System.Drawing.Point(517, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pcbRipplePreview
            // 
            this.pcbRipplePreview.BackColor = System.Drawing.Color.White;
            this.pcbRipplePreview.Location = new System.Drawing.Point(16, 21);
            this.pcbRipplePreview.Name = "pcbRipplePreview";
            this.pcbRipplePreview.Size = new System.Drawing.Size(200, 200);
            this.pcbRipplePreview.TabIndex = 0;
            this.pcbRipplePreview.TabStop = false;
            // 
            // ClickDecorationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ClickDecorationControl";
            this.Size = new System.Drawing.Size(970, 625);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRipplePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSwitch switchEnableClicker;
        private System.Windows.Forms.Button btnColorPicker;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private MaterialSkin.Controls.MaterialButton btnStopAnimation;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbRipplePreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialComboBox cmbAnimDirection;
        private MaterialSkin.Controls.MaterialComboBox cmbInterpolationMode;
        private MaterialSkin.Controls.MaterialSlider sliderAnimSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbProfilesList;
        private MaterialSkin.Controls.MaterialSwitch chkbColorTransition;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
    }
}
