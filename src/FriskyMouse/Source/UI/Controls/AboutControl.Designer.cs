#region License Information (MIT)
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
            splitContainer1 = new SplitContainer();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            lblLatestVersion = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            lblBuildInfo = new MaterialSkin.Controls.MaterialLabel();
            lblAppVersion = new MaterialSkin.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            btnDonate = new MaterialSkin.Controls.MaterialButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            btnLicense = new MaterialSkin.Controls.MaterialButton();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            btnWebstie = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnDeveloper = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(materialDivider1);
            splitContainer1.Panel1.Controls.Add(materialLabel26);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(678, 578);
            splitContainer1.SplitterDistance = 43;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 66;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(23, 40);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(766, 2);
            materialDivider1.TabIndex = 86;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialFontType.H5;
            materialLabel26.Location = new Point(23, 7);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(65, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "About";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(materialLabel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 533);
            panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(23, 264);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(50, 19);
            materialLabel1.TabIndex = 87;
            materialLabel1.Text = "Credits";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(23, 286);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(336, 107);
            richTextBox1.TabIndex = 88;
            richTextBox1.Text = "- Icons set: https://icons8.com/\n- Material Skin 2 (and original developers): https://github.com/leocb/MaterialSkin";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblLatestVersion);
            groupBox3.Controls.Add(materialLabel5);
            groupBox3.Controls.Add(lblBuildInfo);
            groupBox3.Controls.Add(lblAppVersion);
            groupBox3.Location = new Point(400, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 121);
            groupBox3.TabIndex = 88;
            groupBox3.TabStop = false;
            // 
            // lblLatestVersion
            // 
            lblLatestVersion.AutoSize = true;
            lblLatestVersion.Depth = 0;
            lblLatestVersion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLatestVersion.Location = new Point(15, 56);
            lblLatestVersion.MouseState = MaterialSkin.MouseState.HOVER;
            lblLatestVersion.Name = "lblLatestVersion";
            lblLatestVersion.Size = new Size(104, 19);
            lblLatestVersion.TabIndex = 90;
            lblLatestVersion.Text = "Latest version:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(15, -3);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(69, 19);
            materialLabel5.TabIndex = 87;
            materialLabel5.Text = "Build Info";
            // 
            // lblBuildInfo
            // 
            lblBuildInfo.AutoSize = true;
            lblBuildInfo.Depth = 0;
            lblBuildInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuildInfo.Location = new Point(15, 85);
            lblBuildInfo.MouseState = MaterialSkin.MouseState.HOVER;
            lblBuildInfo.Name = "lblBuildInfo";
            lblBuildInfo.Size = new Size(41, 19);
            lblBuildInfo.TabIndex = 89;
            lblBuildInfo.Text = "Build:";
            // 
            // lblAppVersion
            // 
            lblAppVersion.AutoSize = true;
            lblAppVersion.Depth = 0;
            lblAppVersion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAppVersion.Location = new Point(15, 27);
            lblAppVersion.MouseState = MaterialSkin.MouseState.HOVER;
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Size = new Size(111, 19);
            lblAppVersion.TabIndex = 88;
            lblAppVersion.Text = "Current version:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDonate);
            groupBox2.Controls.Add(materialLabel8);
            groupBox2.Controls.Add(btnLicense);
            groupBox2.Controls.Add(materialLabel7);
            groupBox2.Controls.Add(btnWebstie);
            groupBox2.Controls.Add(materialLabel6);
            groupBox2.Controls.Add(materialLabel4);
            groupBox2.Controls.Add(btnDeveloper);
            groupBox2.Controls.Add(materialLabel2);
            groupBox2.Location = new Point(23, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 199);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            // 
            // btnDonate
            // 
            btnDonate.AutoSize = false;
            btnDonate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDonate.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnDonate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnDonate.Depth = 0;
            btnDonate.HighEmphasis = true;
            btnDonate.Icon = Properties.Resources.btn_paypal_94;
            btnDonate.Location = new Point(97, 144);
            btnDonate.Margin = new Padding(4, 6, 4, 6);
            btnDonate.MouseState = MaterialSkin.MouseState.HOVER;
            btnDonate.Name = "btnDonate";
            btnDonate.NoAccentTextColor = Color.Empty;
            btnDonate.Size = new Size(249, 32);
            btnDonate.TabIndex = 97;
            btnDonate.Text = "with PayPal ";
            btnDonate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDonate.UseAccentColor = true;
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += BtnDonate_Click;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(15, 152);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(56, 19);
            materialLabel8.TabIndex = 96;
            materialLabel8.Text = "Donate:";
            // 
            // btnLicense
            // 
            btnLicense.AutoSize = false;
            btnLicense.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLicense.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnLicense.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnLicense.Depth = 0;
            btnLicense.HighEmphasis = true;
            btnLicense.Icon = Properties.Resources.btn_link_64;
            btnLicense.Location = new Point(97, 105);
            btnLicense.Margin = new Padding(4, 6, 4, 6);
            btnLicense.MouseState = MaterialSkin.MouseState.HOVER;
            btnLicense.Name = "btnLicense";
            btnLicense.NoAccentTextColor = Color.Empty;
            btnLicense.Size = new Size(249, 32);
            btnLicense.TabIndex = 95;
            btnLicense.Text = "MIT (open the link for more info)";
            btnLicense.TextAlign = ContentAlignment.MiddleLeft;
            btnLicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnLicense.UseAccentColor = true;
            btnLicense.UseVisualStyleBackColor = true;
            btnLicense.Click += BtnLicense_Click;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(15, 113);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(59, 19);
            materialLabel7.TabIndex = 94;
            materialLabel7.Text = "License:";
            // 
            // btnWebstie
            // 
            btnWebstie.AutoSize = false;
            btnWebstie.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnWebstie.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnWebstie.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnWebstie.Depth = 0;
            btnWebstie.HighEmphasis = true;
            btnWebstie.Icon = Properties.Resources.btn_link_64;
            btnWebstie.Location = new Point(97, 26);
            btnWebstie.Margin = new Padding(4, 6, 4, 6);
            btnWebstie.MouseState = MaterialSkin.MouseState.HOVER;
            btnWebstie.Name = "btnWebstie";
            btnWebstie.NoAccentTextColor = Color.Empty;
            btnWebstie.Size = new Size(249, 32);
            btnWebstie.TabIndex = 93;
            btnWebstie.Text = "https://friskymouse.github.io";
            btnWebstie.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnWebstie.UseAccentColor = false;
            btnWebstie.UseVisualStyleBackColor = true;
            btnWebstie.Click += BtnWebstie_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(15, 73);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(75, 19);
            materialLabel6.TabIndex = 92;
            materialLabel6.Text = "Developer:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(15, 34);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(61, 19);
            materialLabel4.TabIndex = 90;
            materialLabel4.Text = "Website:";
            // 
            // btnDeveloper
            // 
            btnDeveloper.AutoSize = false;
            btnDeveloper.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeveloper.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnDeveloper.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnDeveloper.Depth = 0;
            btnDeveloper.HighEmphasis = true;
            btnDeveloper.Icon = Properties.Resources.btn_link_64;
            btnDeveloper.Location = new Point(97, 65);
            btnDeveloper.Margin = new Padding(4, 6, 4, 6);
            btnDeveloper.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeveloper.Name = "btnDeveloper";
            btnDeveloper.NoAccentTextColor = Color.Empty;
            btnDeveloper.Size = new Size(249, 32);
            btnDeveloper.TabIndex = 88;
            btnDeveloper.Text = "https://github.com/frostybee";
            btnDeveloper.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDeveloper.UseAccentColor = false;
            btnDeveloper.UseVisualStyleBackColor = true;
            btnDeveloper.Click += BtnDeveloper_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, -4);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(39, 19);
            materialLabel2.TabIndex = 87;
            materialLabel2.Text = "Links";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialFontType.H5;
            materialLabel3.Location = new Point(23, 5);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(136, 29);
            materialLabel3.TabIndex = 85;
            materialLabel3.Text = "FriskyMouse";
            // 
            // AboutControl
            // 
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AboutControl";
            Size = new Size(681, 578);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblAppVersion;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblBuildInfo;
        private MaterialSkin.Controls.MaterialButton btnDeveloper;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnWebstie;
        private MaterialSkin.Controls.MaterialButton btnLicense;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnDonate;
        private RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialLabel lblLatestVersion;
    }
}
