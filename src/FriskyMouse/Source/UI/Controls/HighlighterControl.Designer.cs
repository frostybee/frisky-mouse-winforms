#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

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
            GraphicsPath graphicsPath1 = new GraphicsPath();
            colorDialog1 = new ColorDialog();
            switchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pboxPreview = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            switchFilledSpotlight = new MaterialSkin.Controls.MaterialSwitch();
            sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            btnOutlineColorPicker = new Button();
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            cmboxOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            btnResetSettings = new MaterialSkin.Controls.MaterialButton();
            sldRadius = new MaterialSkin.Controls.MaterialSlider();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            btnCurrentShadowColor = new Button();
            btnShadow = new MaterialSkin.Controls.MaterialButton();
            switchShadow = new MaterialSkin.Controls.MaterialSwitch();
            sldShadowDepth = new MaterialSkin.Controls.MaterialSlider();
            sldShadowOpacity = new MaterialSkin.Controls.MaterialSlider();
            groupBox2 = new GroupBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btnOutlineColor = new MaterialSkin.Controls.MaterialButton();
            switchShowOutline = new MaterialSkin.Controls.MaterialSwitch();
            groupBox1 = new GroupBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnSpotlightColor = new Button();
            btnFillColor = new MaterialSkin.Controls.MaterialButton();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            splitContainer1 = new SplitContainer();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            switchHighlighter.Location = new Point(292, 0);
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
            materialCard1.Location = new Point(394, 32);
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
            pboxPreview.Location = new Point(9, 9);
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
            materialLabel2.Location = new Point(403, 6);
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
            sldOpacity.Location = new Point(18, 81);
            sldOpacity.Margin = new Padding(2, 3, 2, 3);
            sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldOpacity.Name = "sldOpacity";
            sldOpacity.RangeMax = 95;
            sldOpacity.RangeMin = 1;
            sldOpacity.Size = new Size(315, 40);
            sldOpacity.TabIndex = 4;
            sldOpacity.Text = "Opacity";
            sldOpacity.ValueMax = 95;
            sldOpacity.ValueSuffix = "%";
            // 
            // switchFilledSpotlight
            // 
            switchFilledSpotlight.AutoSize = true;
            switchFilledSpotlight.Checked = true;
            switchFilledSpotlight.CheckState = CheckState.Checked;
            switchFilledSpotlight.Depth = 0;
            switchFilledSpotlight.Location = new Point(179, 35);
            switchFilledSpotlight.Margin = new Padding(0);
            switchFilledSpotlight.MouseLocation = new Point(-1, -1);
            switchFilledSpotlight.MouseState = MaterialSkin.MouseState.HOVER;
            switchFilledSpotlight.Name = "switchFilledSpotlight";
            switchFilledSpotlight.Ripple = true;
            switchFilledSpotlight.Size = new Size(164, 47);
            switchFilledSpotlight.TabIndex = 14;
            switchFilledSpotlight.Text = "Filled Spotlight ";
            switchFilledSpotlight.UseVisualStyleBackColor = true;
            // 
            // sldOutlineWidth
            // 
            sldOutlineWidth.Depth = 0;
            sldOutlineWidth.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            sldOutlineWidth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldOutlineWidth.Location = new Point(18, 81);
            sldOutlineWidth.Margin = new Padding(2, 3, 2, 3);
            sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            sldOutlineWidth.Name = "sldOutlineWidth";
            sldOutlineWidth.RangeMax = 6;
            sldOutlineWidth.RangeMin = 1;
            sldOutlineWidth.Size = new Size(315, 40);
            sldOutlineWidth.TabIndex = 15;
            sldOutlineWidth.Text = "Width";
            sldOutlineWidth.Value = 1;
            sldOutlineWidth.ValueMax = 6;
            sldOutlineWidth.ValueSuffix = "px";
            // 
            // btnOutlineColorPicker
            // 
            btnOutlineColorPicker.FlatStyle = FlatStyle.Flat;
            btnOutlineColorPicker.Location = new Point(118, 38);
            btnOutlineColorPicker.Margin = new Padding(2, 3, 2, 3);
            btnOutlineColorPicker.Name = "btnOutlineColorPicker";
            btnOutlineColorPicker.Size = new Size(44, 31);
            btnOutlineColorPicker.TabIndex = 85;
            btnOutlineColorPicker.Text = "...";
            btnOutlineColorPicker.UseVisualStyleBackColor = true;
            btnOutlineColorPicker.Click += BtnStrokeColor_Click;
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(536, 258);
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
            cmboxOutlineStyle.DropDownHeight = 118;
            cmboxOutlineStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxOutlineStyle.DropDownWidth = 121;
            cmboxOutlineStyle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmboxOutlineStyle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboxOutlineStyle.FormattingEnabled = true;
            cmboxOutlineStyle.IntegralHeight = false;
            cmboxOutlineStyle.ItemHeight = 29;
            cmboxOutlineStyle.Location = new Point(118, 131);
            cmboxOutlineStyle.Margin = new Padding(4);
            cmboxOutlineStyle.MaxDropDownItems = 4;
            cmboxOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmboxOutlineStyle.Name = "cmboxOutlineStyle";
            cmboxOutlineStyle.Size = new Size(215, 35);
            cmboxOutlineStyle.StartIndex = 0;
            cmboxOutlineStyle.TabIndex = 72;
            cmboxOutlineStyle.UseTallSize = false;
            // 
            // btnResetSettings
            // 
            btnResetSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnResetSettings.Depth = 0;
            btnResetSettings.HighEmphasis = true;
            btnResetSettings.Icon = null;
            btnResetSettings.Location = new Point(403, 258);
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
            sldRadius.Location = new Point(18, 121);
            sldRadius.Margin = new Padding(2, 3, 2, 3);
            sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            sldRadius.Name = "sldRadius";
            sldRadius.RangeMax = 80;
            sldRadius.RangeMin = 1;
            sldRadius.Size = new Size(315, 40);
            sldRadius.TabIndex = 5;
            sldRadius.Text = "Radius  ";
            sldRadius.Value = 30;
            sldRadius.ValueMax = 80;
            sldRadius.ValueSuffix = "px";
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel26.Location = new Point(20, 4);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(194, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "Cursor Highlighter";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(btnResetSettings);
            panel1.Controls.Add(btnApplySettings);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 609);
            panel1.TabIndex = 64;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialLabel6);
            groupBox3.Controls.Add(btnCurrentShadowColor);
            groupBox3.Controls.Add(btnShadow);
            groupBox3.Controls.Add(switchShadow);
            groupBox3.Controls.Add(sldShadowDepth);
            groupBox3.Controls.Add(sldShadowOpacity);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(23, 386);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 165);
            groupBox3.TabIndex = 98;
            groupBox3.TabStop = false;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(7, -2);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(75, 28);
            materialLabel6.TabIndex = 99;
            materialLabel6.Text = "Shadow";
            // 
            // btnCurrentShadowColor
            // 
            btnCurrentShadowColor.FlatStyle = FlatStyle.Flat;
            btnCurrentShadowColor.Location = new Point(118, 34);
            btnCurrentShadowColor.Margin = new Padding(2, 3, 2, 3);
            btnCurrentShadowColor.Name = "btnCurrentShadowColor";
            btnCurrentShadowColor.Size = new Size(44, 33);
            btnCurrentShadowColor.TabIndex = 90;
            btnCurrentShadowColor.Text = "...";
            btnCurrentShadowColor.UseVisualStyleBackColor = true;
            // 
            // btnShadow
            // 
            btnShadow.AutoSize = false;
            btnShadow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShadow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnShadow.Depth = 0;
            btnShadow.HighEmphasis = true;
            btnShadow.Icon = null;
            btnShadow.Location = new Point(18, 32);
            btnShadow.Margin = new Padding(4, 6, 4, 6);
            btnShadow.MouseState = MaterialSkin.MouseState.HOVER;
            btnShadow.Name = "btnShadow";
            btnShadow.NoAccentTextColor = Color.Empty;
            btnShadow.Size = new Size(90, 36);
            btnShadow.TabIndex = 91;
            btnShadow.Text = "Color...";
            btnShadow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShadow.UseAccentColor = false;
            btnShadow.UseVisualStyleBackColor = true;
            btnShadow.Click += BtnShadow_Click;
            // 
            // switchShadow
            // 
            switchShadow.AutoSize = true;
            switchShadow.Checked = true;
            switchShadow.CheckState = CheckState.Checked;
            switchShadow.Depth = 0;
            switchShadow.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            switchShadow.Location = new Point(179, 27);
            switchShadow.Margin = new Padding(0);
            switchShadow.MouseLocation = new Point(-1, -1);
            switchShadow.MouseState = MaterialSkin.MouseState.HOVER;
            switchShadow.Name = "switchShadow";
            switchShadow.Ripple = true;
            switchShadow.Size = new Size(160, 47);
            switchShadow.TabIndex = 88;
            switchShadow.Text = "Show Shadow ";
            switchShadow.UseVisualStyleBackColor = true;
            // 
            // sldShadowDepth
            // 
            sldShadowDepth.Depth = 0;
            sldShadowDepth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldShadowDepth.Location = new Point(18, 77);
            sldShadowDepth.Margin = new Padding(2, 3, 2, 3);
            sldShadowDepth.MouseState = MaterialSkin.MouseState.HOVER;
            sldShadowDepth.Name = "sldShadowDepth";
            sldShadowDepth.RangeMax = 15;
            sldShadowDepth.RangeMin = 1;
            sldShadowDepth.Size = new Size(315, 40);
            sldShadowDepth.TabIndex = 93;
            sldShadowDepth.Text = "Depth";
            sldShadowDepth.Value = 2;
            sldShadowDepth.ValueMax = 15;
            sldShadowDepth.ValueSuffix = "px";
            // 
            // sldShadowOpacity
            // 
            sldShadowOpacity.Depth = 0;
            sldShadowOpacity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldShadowOpacity.Location = new Point(18, 117);
            sldShadowOpacity.Margin = new Padding(2, 3, 2, 3);
            sldShadowOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            sldShadowOpacity.Name = "sldShadowOpacity";
            sldShadowOpacity.RangeMax = 95;
            sldShadowOpacity.RangeMin = 1;
            sldShadowOpacity.Size = new Size(315, 40);
            sldShadowOpacity.TabIndex = 95;
            sldShadowOpacity.Text = "Opcaity";
            sldShadowOpacity.Value = 30;
            sldShadowOpacity.ValueMax = 95;
            sldShadowOpacity.ValueSuffix = "%";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialLabel1);
            groupBox2.Controls.Add(materialLabel5);
            groupBox2.Controls.Add(btnOutlineColor);
            groupBox2.Controls.Add(switchShowOutline);
            groupBox2.Controls.Add(btnOutlineColorPicker);
            groupBox2.Controls.Add(sldOutlineWidth);
            groupBox2.Controls.Add(cmboxOutlineStyle);
            groupBox2.Location = new Point(23, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 178);
            groupBox2.TabIndex = 97;
            groupBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.Popup;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 137);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(93, 19);
            materialLabel1.TabIndex = 100;
            materialLabel1.Text = "Outline Style";
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(7, -3);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(75, 19);
            materialLabel5.TabIndex = 98;
            materialLabel5.Text = "Outline";
            // 
            // btnOutlineColor
            // 
            btnOutlineColor.AutoSize = false;
            btnOutlineColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOutlineColor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnOutlineColor.Depth = 0;
            btnOutlineColor.HighEmphasis = true;
            btnOutlineColor.Icon = null;
            btnOutlineColor.Location = new Point(18, 35);
            btnOutlineColor.Margin = new Padding(4, 6, 4, 6);
            btnOutlineColor.MouseState = MaterialSkin.MouseState.HOVER;
            btnOutlineColor.Name = "btnOutlineColor";
            btnOutlineColor.NoAccentTextColor = Color.Empty;
            btnOutlineColor.Size = new Size(90, 36);
            btnOutlineColor.TabIndex = 87;
            btnOutlineColor.Text = "Color...";
            btnOutlineColor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOutlineColor.UseAccentColor = false;
            btnOutlineColor.UseVisualStyleBackColor = true;
            btnOutlineColor.Click += BtnStrokeColor_Click;
            // 
            // switchShowOutline
            // 
            switchShowOutline.AutoSize = true;
            switchShowOutline.Checked = true;
            switchShowOutline.CheckState = CheckState.Checked;
            switchShowOutline.Depth = 0;
            switchShowOutline.Location = new Point(179, 31);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(materialLabel4);
            groupBox1.Controls.Add(btnSpotlightColor);
            groupBox1.Controls.Add(sldRadius);
            groupBox1.Controls.Add(btnFillColor);
            groupBox1.Controls.Add(sldOpacity);
            groupBox1.Controls.Add(switchFilledSpotlight);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 169);
            groupBox1.TabIndex = 96;
            groupBox1.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.FlatStyle = FlatStyle.Popup;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(7, -1);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(75, 19);
            materialLabel4.TabIndex = 97;
            materialLabel4.Text = "Spotlight";
            // 
            // btnSpotlightColor
            // 
            btnSpotlightColor.FlatStyle = FlatStyle.Flat;
            btnSpotlightColor.Location = new Point(118, 39);
            btnSpotlightColor.Margin = new Padding(2, 3, 2, 3);
            btnSpotlightColor.Name = "btnSpotlightColor";
            btnSpotlightColor.Size = new Size(44, 31);
            btnSpotlightColor.TabIndex = 99;
            btnSpotlightColor.Text = "...";
            btnSpotlightColor.UseVisualStyleBackColor = true;
            // 
            // btnFillColor
            // 
            btnFillColor.AutoSize = false;
            btnFillColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFillColor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFillColor.Depth = 0;
            btnFillColor.HighEmphasis = true;
            btnFillColor.Icon = null;
            btnFillColor.Location = new Point(18, 35);
            btnFillColor.Margin = new Padding(4, 6, 4, 6);
            btnFillColor.MouseState = MaterialSkin.MouseState.HOVER;
            btnFillColor.Name = "btnFillColor";
            btnFillColor.NoAccentTextColor = Color.Empty;
            btnFillColor.Size = new Size(90, 36);
            btnFillColor.TabIndex = 78;
            btnFillColor.Text = "Fill...";
            btnFillColor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFillColor.UseAccentColor = false;
            btnFillColor.UseVisualStyleBackColor = true;
            btnFillColor.Click += BtnFillColor_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(15, 40);
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
            splitContainer1.Panel1.Controls.Add(switchHighlighter);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(765, 660);
            splitContainer1.SplitterDistance = 47;
            splitContainer1.TabIndex = 65;
            // 
            // HighlighterControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "HighlighterControl";
            Size = new Size(831, 693);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnOutlineColorPicker;
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
        private MaterialSkin.Controls.MaterialButton btnFillColor;
        private MaterialSkin.Controls.MaterialButton btnOutlineColor;
        private MaterialSkin.Controls.MaterialSwitch switchShadow;
        private MaterialSkin.Controls.MaterialSwitch switchShowOutline;
        private MaterialSkin.Controls.MaterialButton btnShadow;
        private Button btnCurrentShadowColor;
        private MaterialSkin.Controls.MaterialSlider sldShadowDepth;
        private MaterialSkin.Controls.MaterialSlider sldShadowOpacity;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Button btnSpotlightColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        //private Button Bt;
    }
}
