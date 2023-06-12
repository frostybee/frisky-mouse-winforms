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
            materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            materialSpinner1 = new MaterialSkin.Controls.MaterialSpinner();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel26.Location = new Point(4, 0);
            materialLabel26.Margin = new Padding(4, 0, 4, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(91, 41);
            materialLabel26.TabIndex = 63;
            materialLabel26.Text = "About";
            // 
            // materialSpinner1
            // 
            materialSpinner1.Depth = 0;
            materialSpinner1.Location = new Point(6, 55);
            materialSpinner1.MaxValue = 100;
            materialSpinner1.MinValue = 0;
            materialSpinner1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSpinner1.Name = "materialSpinner1";
            materialSpinner1.Size = new Size(201, 40);
            materialSpinner1.TabIndex = 64;
            materialSpinner1.Text = "materialSpinner1";
            materialSpinner1.Value = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialSpinner1);
            groupBox1.Location = new Point(4, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 204);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(materialLabel26);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AboutControl";
            Size = new Size(708, 412);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialSpinner materialSpinner1;
        private GroupBox groupBox1;
    }
}
