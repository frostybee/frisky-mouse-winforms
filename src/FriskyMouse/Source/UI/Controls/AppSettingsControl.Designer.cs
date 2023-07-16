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
    partial class AppSettingsControl
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
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            switchColoredDrawer = new MaterialSkin.Controls.MaterialSwitch();
            cmbColorScheme = new MaterialSkin.Controls.MaterialComboBox();
            switchChangeTheme = new MaterialSkin.Controls.MaterialSwitch();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.Size = new Size(483, 329);
            splitContainer1.SplitterDistance = 36;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 66;
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialFontType.H5;
            materialLabel26.Location = new Point(23, 3);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(215, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "Application Settings";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(materialDivider1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 291);
            panel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(switchColoredDrawer);
            groupBox1.Controls.Add(cmbColorScheme);
            groupBox1.Controls.Add(switchChangeTheme);
            groupBox1.Location = new Point(23, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 163);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(97, 19);
            materialLabel2.TabIndex = 84;
            materialLabel2.Text = "Look and feel";
            // 
            // switchColoredDrawer
            // 
            switchColoredDrawer.AutoSize = true;
            switchColoredDrawer.Depth = 0;
            switchColoredDrawer.Location = new Point(17, 100);
            switchColoredDrawer.Margin = new Padding(0);
            switchColoredDrawer.MouseLocation = new Point(-1, -1);
            switchColoredDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            switchColoredDrawer.Name = "switchColoredDrawer";
            switchColoredDrawer.Ripple = true;
            switchColoredDrawer.Size = new Size(162, 47);
            switchColoredDrawer.TabIndex = 82;
            switchColoredDrawer.Text = "Colored Drawer";
            switchColoredDrawer.UseVisualStyleBackColor = true;
            // 
            // cmbColorScheme
            // 
            cmbColorScheme.AutoResize = false;
            cmbColorScheme.BackColor = Color.FromArgb(255, 255, 255);
            cmbColorScheme.Depth = 0;
            cmbColorScheme.DrawMode = DrawMode.OwnerDrawVariable;
            cmbColorScheme.DropDownHeight = 174;
            cmbColorScheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColorScheme.DropDownWidth = 121;
            cmbColorScheme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbColorScheme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbColorScheme.FormattingEnabled = true;
            cmbColorScheme.Hint = "Select Color Scheme";
            cmbColorScheme.IntegralHeight = false;
            cmbColorScheme.ItemHeight = 43;
            cmbColorScheme.Location = new Point(17, 37);
            cmbColorScheme.MaxDropDownItems = 4;
            cmbColorScheme.MouseState = MaterialSkin.MouseState.OUT;
            cmbColorScheme.Name = "cmbColorScheme";
            cmbColorScheme.Size = new Size(198, 49);
            cmbColorScheme.StartIndex = 0;
            cmbColorScheme.TabIndex = 81;
            // 
            // switchChangeTheme
            // 
            switchChangeTheme.AutoSize = true;
            switchChangeTheme.Depth = 0;
            switchChangeTheme.Location = new Point(235, 39);
            switchChangeTheme.Margin = new Padding(0);
            switchChangeTheme.MouseLocation = new Point(-1, -1);
            switchChangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            switchChangeTheme.Name = "switchChangeTheme";
            switchChangeTheme.Ripple = true;
            switchChangeTheme.Size = new Size(148, 47);
            switchChangeTheme.TabIndex = 79;
            switchChangeTheme.Text = "Dark Theme  ";
            switchChangeTheme.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(22, -1);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(699, 3);
            materialDivider1.TabIndex = 76;
            materialDivider1.Text = "materialDivider1";
            // 
            // AppSettingsControl
            // 
            Controls.Add(splitContainer1);
            Name = "AppSettingsControl";
            Size = new Size(643, 417);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSwitch switchChangeTheme;
        private MaterialSkin.Controls.MaterialComboBox cmbColorScheme;
        private MaterialSkin.Controls.MaterialSwitch switchColoredDrawer;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
