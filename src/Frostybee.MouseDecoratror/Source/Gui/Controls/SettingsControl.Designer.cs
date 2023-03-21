namespace Frostybee.MouseDecorator.Source.Gui.Controls
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
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.btnApplySettings = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel26.Location = new System.Drawing.Point(13, 16);
            this.materialLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(303, 41);
            this.materialLabel26.TabIndex = 63;
            this.materialLabel26.Text = "Application Settings";
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApplySettings.Depth = 0;
            this.btnApplySettings.HighEmphasis = true;
            this.btnApplySettings.Icon = null;
            this.btnApplySettings.Location = new System.Drawing.Point(249, 103);
            this.btnApplySettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApplySettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApplySettings.Size = new System.Drawing.Size(67, 36);
            this.btnApplySettings.TabIndex = 9;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApplySettings.UseAccentColor = false;
            this.btnApplySettings.UseVisualStyleBackColor = true;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApplySettings);
            this.Controls.Add(this.materialLabel26);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(620, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialButton btnApplySettings;
    }
}
