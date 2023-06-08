namespace FriskyMouse.UI.Controls
{
    partial class SettingsControl
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
            btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            SuspendLayout();
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel26.Location = new Point(13, 20);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(303, 41);
            materialLabel26.TabIndex = 63;
            materialLabel26.Text = "Application Settings";
            // 
            // btnApplySettings
            // 
            btnApplySettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApplySettings.Depth = 0;
            btnApplySettings.HighEmphasis = true;
            btnApplySettings.Icon = null;
            btnApplySettings.Location = new Point(249, 129);
            btnApplySettings.Margin = new Padding(4, 8, 4, 8);
            btnApplySettings.MouseState = MaterialSkin.MouseState.HOVER;
            btnApplySettings.Name = "btnApplySettings";
            btnApplySettings.NoAccentTextColor = Color.Empty;
            btnApplySettings.Size = new Size(67, 36);
            btnApplySettings.TabIndex = 9;
            btnApplySettings.Text = "Apply";
            btnApplySettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApplySettings.UseAccentColor = false;
            btnApplySettings.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(145, 256);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(171, 37);
            materialCheckbox1.TabIndex = 64;
            materialCheckbox1.Text = "materialCheckbox1";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCheckbox1);
            Controls.Add(btnApplySettings);
            Controls.Add(materialLabel26);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingsControl";
            Size = new Size(620, 444);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}
