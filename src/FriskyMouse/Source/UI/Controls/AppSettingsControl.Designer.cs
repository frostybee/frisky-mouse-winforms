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
            splitContainer1 = new SplitContainer();
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnChangeColor = new MaterialSkin.Controls.MaterialButton();
            switchChangeTheme = new MaterialSkin.Controls.MaterialSwitch();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer1.Size = new Size(850, 646);
            splitContainer1.SplitterDistance = 32;
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
            materialLabel26.Size = new Size(215, 29);
            materialLabel26.TabIndex = 62;
            materialLabel26.Text = "Application Settings";
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(btnChangeColor);
            panel1.Controls.Add(switchChangeTheme);
            panel1.Controls.Add(materialDivider1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 610);
            panel1.TabIndex = 64;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(22, 34);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(100, 19);
            materialLabel1.TabIndex = 80;
            materialLabel1.Text = "Look and Feel";
            // 
            // btnChangeColor
            // 
            btnChangeColor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnChangeColor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnChangeColor.Depth = 0;
            btnChangeColor.HighEmphasis = true;
            btnChangeColor.Icon = null;
            btnChangeColor.Location = new Point(22, 61);
            btnChangeColor.Margin = new Padding(4, 6, 4, 6);
            btnChangeColor.MouseState = MaterialSkin.MouseState.HOVER;
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.NoAccentTextColor = Color.Empty;
            btnChangeColor.Size = new Size(140, 36);
            btnChangeColor.TabIndex = 77;
            btnChangeColor.Text = "Change Colors";
            btnChangeColor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnChangeColor.UseAccentColor = false;
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += BtnChangeColor_Click;
            // 
            // switchChangeTheme
            // 
            switchChangeTheme.AutoSize = true;
            switchChangeTheme.Depth = 0;
            switchChangeTheme.Location = new Point(179, 61);
            switchChangeTheme.Margin = new Padding(0);
            switchChangeTheme.MouseLocation = new Point(-1, -1);
            switchChangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            switchChangeTheme.Name = "switchChangeTheme";
            switchChangeTheme.Ripple = true;
            switchChangeTheme.Size = new Size(148, 47);
            switchChangeTheme.TabIndex = 79;
            switchChangeTheme.Text = "Dark Theme  ";
            switchChangeTheme.UseVisualStyleBackColor = true;
            switchChangeTheme.CheckedChanged += SwitchChangeTheme_CheckedChanged;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "AppSettingsControl";
            Size = new Size(871, 672);
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

        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btnChangeColor;
        private MaterialSkin.Controls.MaterialSwitch switchChangeTheme;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
