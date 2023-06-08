namespace FriskyMouse.Source.UI.Controls
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(materialLabel26);
            splitContainer1.Size = new Size(809, 549);
            splitContainer1.SplitterDistance = 53;
            splitContainer1.TabIndex = 0;
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel26.Location = new Point(25, 6);
            materialLabel26.Margin = new Padding(5, 0, 5, 0);
            materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(91, 41);
            materialLabel26.TabIndex = 63;
            materialLabel26.Text = "About";
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "AboutControl";
            Size = new Size(809, 549);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
    }
}
