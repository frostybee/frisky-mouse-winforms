﻿#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.UI.Controls
{
    partial class ClickIndicatorControl
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
            lblControlTitle = new MaterialSkin.Controls.MaterialLabel();
            groupBox3 = new GroupBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            sldOpacityMultiplier = new MaterialSkin.Controls.MaterialSlider();
            btnFillColor = new Button();
            btnColorPicker = new MaterialSkin.Controls.MaterialButton();
            switchColorTransition = new MaterialSkin.Controls.MaterialSwitch();
            cmbProfilesList = new MaterialSkin.Controls.MaterialComboBox();
            sldRadiusMultiplier = new MaterialSkin.Controls.MaterialSlider();
            groupBox2 = new GroupBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            sliderAnimSpeed = new MaterialSkin.Controls.MaterialSlider();
            cmbInterpolationMode = new MaterialSkin.Controls.MaterialComboBox();
            cmbAnimDirection = new MaterialSkin.Controls.MaterialComboBox();
            switchClickDecoration = new MaterialSkin.Controls.MaterialSwitch();
            btnPreview = new MaterialSkin.Controls.MaterialButton();
            pcbRipplePreview = new PictureBox();
            splitContainer1 = new SplitContainer();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            panel1 = new Panel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // lblControlTitle
            // 
            lblControlTitle.AutoSize = true;
            lblControlTitle.Depth = 0;
            lblControlTitle.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblControlTitle.FontType = MaterialSkin.MaterialFontType.H5;
            lblControlTitle.Location = new Point(23, 7);
            lblControlTitle.Margin = new Padding(4, 0, 4, 0);
            lblControlTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblControlTitle.Name = "lblControlTitle";
            lblControlTitle.Size = new Size(211, 29);
            lblControlTitle.TabIndex = 62;
            lblControlTitle.Text = "Left Click Indecator";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialLabel3);
            groupBox3.Controls.Add(sldOpacityMultiplier);
            groupBox3.Controls.Add(btnFillColor);
            groupBox3.Controls.Add(btnColorPicker);
            groupBox3.Controls.Add(switchColorTransition);
            groupBox3.Controls.Add(cmbProfilesList);
            groupBox3.Controls.Add(sldRadiusMultiplier);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(19, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 231);
            groupBox3.TabIndex = 78;
            groupBox3.TabStop = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(13, -1);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(104, 19);
            materialLabel3.TabIndex = 84;
            materialLabel3.Text = "Ripple Options";
            // 
            // sldOpacityMultiplier
            // 
            sldOpacityMultiplier.Depth = 0;
            sldOpacityMultiplier.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            sldOpacityMultiplier.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOpacityMultiplier.Location = new Point(18, 124);
            sldOpacityMultiplier.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacityMultiplier.Name = "sldOpacityMultiplier";
            sldOpacityMultiplier.RangeMax = 95;
            sldOpacityMultiplier.RangeMin = 1;
            sldOpacityMultiplier.Size = new Size(336, 40);
            sldOpacityMultiplier.TabIndex = 90;
            sldOpacityMultiplier.Text = "Fading Opacity";
            sldOpacityMultiplier.Value = 7;
            sldOpacityMultiplier.ValueMax = 95;
            sldOpacityMultiplier.ValueSuffix = "%";
            // 
            // btnFillColor
            // 
            btnFillColor.FlatStyle = FlatStyle.Flat;
            btnFillColor.Location = new Point(152, 175);
            btnFillColor.Margin = new Padding(2, 3, 2, 3);
            btnFillColor.Name = "btnFillColor";
            btnFillColor.Size = new Size(48, 33);
            btnFillColor.TabIndex = 89;
            btnFillColor.Text = "...";
            btnFillColor.UseVisualStyleBackColor = true;
            // 
            // btnColorPicker
            // 
            btnColorPicker.AutoSize = false;
            btnColorPicker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnColorPicker.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnColorPicker.Depth = 0;
            btnColorPicker.HighEmphasis = true;
            btnColorPicker.Icon = Properties.Resources.fill_color_50;
            btnColorPicker.Location = new Point(19, 173);
            btnColorPicker.Margin = new Padding(4, 6, 4, 6);
            btnColorPicker.MouseState = MaterialSkin.MouseState.HOVER;
            btnColorPicker.Name = "btnColorPicker";
            btnColorPicker.NoAccentTextColor = Color.Empty;
            btnColorPicker.Size = new Size(127, 37);
            btnColorPicker.TabIndex = 88;
            btnColorPicker.Text = "Color...";
            btnColorPicker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnColorPicker.UseAccentColor = false;
            btnColorPicker.UseVisualStyleBackColor = true;
            // 
            // switchColorTransition
            // 
            switchColorTransition.AutoSize = true;
            switchColorTransition.Checked = true;
            switchColorTransition.CheckState = CheckState.Checked;
            switchColorTransition.Depth = 0;
            switchColorTransition.Location = new Point(232, 34);
            switchColorTransition.Margin = new Padding(0);
            switchColorTransition.MouseLocation = new Point(-1, -1);
            switchColorTransition.MouseState = MaterialSkin.MouseState.HOVER;
            switchColorTransition.Name = "switchColorTransition";
            switchColorTransition.Ripple = true;
            switchColorTransition.Size = new Size(134, 47);
            switchColorTransition.TabIndex = 79;
            switchColorTransition.Text = "Fade Color ";
            switchColorTransition.UseVisualStyleBackColor = true;
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
            cmbProfilesList.Location = new Point(18, 31);
            cmbProfilesList.Margin = new Padding(4);
            cmbProfilesList.MaxDropDownItems = 4;
            cmbProfilesList.MouseState = MaterialSkin.MouseState.OUT;
            cmbProfilesList.Name = "cmbProfilesList";
            cmbProfilesList.Size = new Size(210, 49);
            cmbProfilesList.StartIndex = 0;
            cmbProfilesList.TabIndex = 76;
            // 
            // sldRadiusMultiplier
            // 
            sldRadiusMultiplier.Depth = 0;
            sldRadiusMultiplier.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            sldRadiusMultiplier.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldRadiusMultiplier.Location = new Point(18, 84);
            sldRadiusMultiplier.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadiusMultiplier.Name = "sldRadiusMultiplier";
            sldRadiusMultiplier.RangeMax = 25;
            sldRadiusMultiplier.RangeMin = 1;
            sldRadiusMultiplier.Size = new Size(336, 40);
            sldRadiusMultiplier.TabIndex = 5;
            sldRadiusMultiplier.Text = "Radius";
            sldRadiusMultiplier.Value = 1;
            sldRadiusMultiplier.ValueMax = 25;
            sldRadiusMultiplier.ValueSuffix = "%";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialLabel1);
            groupBox2.Controls.Add(sliderAnimSpeed);
            groupBox2.Controls.Add(cmbInterpolationMode);
            groupBox2.Controls.Add(cmbAnimDirection);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 132);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(13, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(133, 19);
            materialLabel1.TabIndex = 83;
            materialLabel1.Text = "Animation Options";
            // 
            // sliderAnimSpeed
            // 
            sliderAnimSpeed.Depth = 0;
            sliderAnimSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderAnimSpeed.Location = new Point(18, 24);
            sliderAnimSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderAnimSpeed.Name = "sliderAnimSpeed";
            sliderAnimSpeed.RangeMax = 50;
            sliderAnimSpeed.RangeMin = 1;
            sliderAnimSpeed.Size = new Size(336, 40);
            sliderAnimSpeed.TabIndex = 76;
            sliderAnimSpeed.Text = "Speed";
            sliderAnimSpeed.Value = 30;
            sliderAnimSpeed.ValueMax = 50;
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
            cmbInterpolationMode.Hint = "Easing Function";
            cmbInterpolationMode.ImeMode = ImeMode.Off;
            cmbInterpolationMode.IntegralHeight = false;
            cmbInterpolationMode.ItemHeight = 43;
            cmbInterpolationMode.Location = new Point(211, 71);
            cmbInterpolationMode.Margin = new Padding(4);
            cmbInterpolationMode.MaxDropDownItems = 4;
            cmbInterpolationMode.MouseState = MaterialSkin.MouseState.OUT;
            cmbInterpolationMode.Name = "cmbInterpolationMode";
            cmbInterpolationMode.Size = new Size(172, 49);
            cmbInterpolationMode.StartIndex = 0;
            cmbInterpolationMode.TabIndex = 77;
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
            cmbAnimDirection.Hint = "Animation Direction";
            cmbAnimDirection.IntegralHeight = false;
            cmbAnimDirection.ItemHeight = 43;
            cmbAnimDirection.Location = new Point(18, 71);
            cmbAnimDirection.Margin = new Padding(4);
            cmbAnimDirection.MaxDropDownItems = 4;
            cmbAnimDirection.MouseState = MaterialSkin.MouseState.OUT;
            cmbAnimDirection.Name = "cmbAnimDirection";
            cmbAnimDirection.Size = new Size(187, 49);
            cmbAnimDirection.StartIndex = 0;
            cmbAnimDirection.TabIndex = 76;
            // 
            // switchClickDecoration
            // 
            switchClickDecoration.AutoSize = true;
            switchClickDecoration.Checked = true;
            switchClickDecoration.CheckState = CheckState.Checked;
            switchClickDecoration.Depth = 0;
            switchClickDecoration.Location = new Point(315, -1);
            switchClickDecoration.Margin = new Padding(0);
            switchClickDecoration.MouseLocation = new Point(-1, -1);
            switchClickDecoration.MouseState = MaterialSkin.MouseState.HOVER;
            switchClickDecoration.Name = "switchClickDecoration";
            switchClickDecoration.Ripple = true;
            switchClickDecoration.Size = new Size(74, 47);
            switchClickDecoration.TabIndex = 1;
            switchClickDecoration.Text = "On";
            switchClickDecoration.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.AutoSize = false;
            btnPreview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPreview.Depth = 0;
            btnPreview.HighEmphasis = true;
            btnPreview.Icon = Properties.Resources.btn_preview_50;
            btnPreview.Location = new Point(515, 271);
            btnPreview.Margin = new Padding(4, 6, 4, 6);
            btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            btnPreview.Name = "btnPreview";
            btnPreview.NoAccentTextColor = Color.Empty;
            btnPreview.Size = new Size(122, 37);
            btnPreview.TabIndex = 9;
            btnPreview.Text = "Preview";
            btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPreview.UseAccentColor = false;
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += BtnPreview_Click;
            // 
            // pcbRipplePreview
            // 
            pcbRipplePreview.BackColor = Color.White;
            pcbRipplePreview.Location = new Point(8, 9);
            pcbRipplePreview.Name = "pcbRipplePreview";
            pcbRipplePreview.Size = new Size(204, 218);
            pcbRipplePreview.TabIndex = 0;
            pcbRipplePreview.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 2);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblControlTitle);
            splitContainer1.Panel1.Controls.Add(materialDivider1);
            splitContainer1.Panel1.Controls.Add(switchClickDecoration);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(799, 534);
            splitContainer1.SplitterDistance = 55;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 2;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(23, 47);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(766, 2);
            materialDivider1.TabIndex = 77;
            materialDivider1.Text = "materialDivider1";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(btnPreview);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 477);
            panel1.TabIndex = 3;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(431, 4);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 82;
            materialLabel2.Text = "Preview";
            // 
            // materialCard1
            // 
            materialCard1.Controls.Add(pcbRipplePreview);
            materialCard1.Depth = 0;
            materialCard1.Elevation = 5;
            materialCard1.LargeTitle = false;
            materialCard1.Location = new Point(425, 26);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(5, 25, 5, 5);
            graphicsPath1.FillMode = FillMode.Alternate;
            materialCard1.ShadowBorder = graphicsPath1;
            materialCard1.Size = new Size(220, 236);
            materialCard1.TabIndex = 79;
            materialCard1.Title = null;
            // 
            // ClickIndicatorControl
            // 
            Controls.Add(splitContainer1);
            Name = "ClickIndicatorControl";
            Size = new Size(833, 582);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRipplePreview).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialSwitch switchClickDecoration;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private MaterialSkin.Controls.MaterialSlider sldRadiusMultiplier;
        private PictureBox pcbRipplePreview;
        private MaterialSkin.Controls.MaterialLabel lblControlTitle;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialComboBox cmbAnimDirection;
        private MaterialSkin.Controls.MaterialComboBox cmbInterpolationMode;
        private MaterialSkin.Controls.MaterialSlider sliderAnimSpeed;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbProfilesList;
        private MaterialSkin.Controls.MaterialSwitch switchColorTransition;
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnColorPicker;
        private Button btnFillColor;
        private MaterialSkin.Controls.MaterialSlider sldOpacityMultiplier;
    }
}
