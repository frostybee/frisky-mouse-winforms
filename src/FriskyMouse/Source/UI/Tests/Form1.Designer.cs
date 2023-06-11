namespace FriskyMouse.Source.UI.Forms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            highlighterControl1 = new FriskyMouse.UI.Controls.HighlighterControl();
            SuspendLayout();
            // 
            // highlighterControl1
            // 
            highlighterControl1.Dock = DockStyle.Fill;
            highlighterControl1.Location = new Point(0, 0);
            highlighterControl1.Margin = new Padding(2, 3, 2, 3);
            highlighterControl1.Name = "highlighterControl1";
            highlighterControl1.Size = new Size(800, 445);
            highlighterControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(highlighterControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FriskyMouse.UI.Controls.HighlighterControl highlighterControl1;
    }
}