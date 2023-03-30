
namespace Frostybee.MouseDecorator.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpCursorSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCursorSize = new System.Windows.Forms.TextBox();
            this.tbCursorSize = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCursorOpacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCursorOpacity = new System.Windows.Forms.TrackBar();
            this.lblCursorOpacityMax = new System.Windows.Forms.Label();
            this.btnCursorColor = new System.Windows.Forms.Button();
            this.lblCursorOpacityMin = new System.Windows.Forms.Label();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpCursorSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursorOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCursorSettings
            // 
            this.grpCursorSettings.Controls.Add(this.label5);
            this.grpCursorSettings.Controls.Add(this.txtCursorSize);
            this.grpCursorSettings.Controls.Add(this.tbCursorSize);
            this.grpCursorSettings.Controls.Add(this.label4);
            this.grpCursorSettings.Controls.Add(this.label1);
            this.grpCursorSettings.Controls.Add(this.txtCursorOpacity);
            this.grpCursorSettings.Controls.Add(this.label2);
            this.grpCursorSettings.Controls.Add(this.label3);
            this.grpCursorSettings.Controls.Add(this.tbCursorOpacity);
            this.grpCursorSettings.Controls.Add(this.lblCursorOpacityMax);
            this.grpCursorSettings.Controls.Add(this.btnCursorColor);
            this.grpCursorSettings.Controls.Add(this.lblCursorOpacityMin);
            this.grpCursorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCursorSettings.Location = new System.Drawing.Point(15, 17);
            this.grpCursorSettings.Margin = new System.Windows.Forms.Padding(4);
            this.grpCursorSettings.Name = "grpCursorSettings";
            this.grpCursorSettings.Padding = new System.Windows.Forms.Padding(4);
            this.grpCursorSettings.Size = new System.Drawing.Size(809, 755);
            this.grpCursorSettings.TabIndex = 1;
            this.grpCursorSettings.TabStop = false;
            this.grpCursorSettings.Text = "Cursor Highlight Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size:";
            // 
            // txtCursorSize
            // 
            this.txtCursorSize.Location = new System.Drawing.Point(274, 113);
            this.txtCursorSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursorSize.Multiline = true;
            this.txtCursorSize.Name = "txtCursorSize";
            this.txtCursorSize.Size = new System.Drawing.Size(80, 35);
            this.txtCursorSize.TabIndex = 3;
            this.txtCursorSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCursorSize
            // 
            this.tbCursorSize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCursorSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCursorSize.Location = new System.Drawing.Point(72, 95);
            this.tbCursorSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbCursorSize.Maximum = 100;
            this.tbCursorSize.Minimum = 20;
            this.tbCursorSize.Name = "tbCursorSize";
            this.tbCursorSize.Size = new System.Drawing.Size(115, 80);
            this.tbCursorSize.TabIndex = 2;
            this.tbCursorSize.TickFrequency = 10;
            this.tbCursorSize.Value = 20;
            this.tbCursorSize.Scroll += new System.EventHandler(this.sliderCursorSize_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "OpacityPercentage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "100";
            // 
            // txtCursorOpacity
            // 
            this.txtCursorOpacity.Location = new System.Drawing.Point(275, 245);
            this.txtCursorOpacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursorOpacity.Multiline = true;
            this.txtCursorOpacity.Name = "txtCursorOpacity";
            this.txtCursorOpacity.Size = new System.Drawing.Size(80, 45);
            this.txtCursorOpacity.TabIndex = 3;
            this.txtCursorOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Highlight Color:";
            // 
            // tbCursorOpacity
            // 
            this.tbCursorOpacity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCursorOpacity.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCursorOpacity.Location = new System.Drawing.Point(73, 241);
            this.tbCursorOpacity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCursorOpacity.Maximum = 255;
            this.tbCursorOpacity.Minimum = 20;
            this.tbCursorOpacity.Name = "tbCursorOpacity";
            this.tbCursorOpacity.Size = new System.Drawing.Size(127, 80);
            this.tbCursorOpacity.TabIndex = 2;
            this.tbCursorOpacity.TickFrequency = 10;
            this.tbCursorOpacity.Value = 20;
            this.tbCursorOpacity.Scroll += new System.EventHandler(this.SliderCursorOpacity_Scroll);
            // 
            // lblCursorOpacityMax
            // 
            this.lblCursorOpacityMax.AutoSize = true;
            this.lblCursorOpacityMax.Location = new System.Drawing.Point(208, 258);
            this.lblCursorOpacityMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursorOpacityMax.Name = "lblCursorOpacityMax";
            this.lblCursorOpacityMax.Size = new System.Drawing.Size(48, 25);
            this.lblCursorOpacityMax.TabIndex = 1;
            this.lblCursorOpacityMax.Text = "255";
            // 
            // btnCursorColor
            // 
            this.btnCursorColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursorColor.Location = new System.Drawing.Point(254, 312);
            this.btnCursorColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCursorColor.Name = "btnCursorColor";
            this.btnCursorColor.Size = new System.Drawing.Size(144, 62);
            this.btnCursorColor.TabIndex = 1;
            this.btnCursorColor.Text = "...";
            this.btnCursorColor.UseVisualStyleBackColor = true;
            this.btnCursorColor.Click += new System.EventHandler(this.SelectCursorColor_Click);
            // 
            // lblCursorOpacityMin
            // 
            this.lblCursorOpacityMin.AutoSize = true;
            this.lblCursorOpacityMin.Location = new System.Drawing.Point(16, 266);
            this.lblCursorOpacityMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursorOpacityMin.Name = "lblCursorOpacityMin";
            this.lblCursorOpacityMin.Size = new System.Drawing.Size(36, 25);
            this.lblCursorOpacityMin.TabIndex = 0;
            this.lblCursorOpacityMin.Text = "20";
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotifyIcon.BalloonTipText = "Buzzing in progress! ";
            this.appNotifyIcon.BalloonTipTitle = "Frostybee\'s MouseDecorator";
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "notifyIcon1";
            this.appNotifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 959);
            this.Controls.Add(this.grpCursorSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Frostybee\'s Mouse Decorator";
            this.grpCursorSettings.ResumeLayout(false);
            this.grpCursorSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursorOpacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCursorSettings;
        private System.Windows.Forms.TrackBar tbCursorOpacity;
        private System.Windows.Forms.Label lblCursorOpacityMax;
        private System.Windows.Forms.Label lblCursorOpacityMin;
        private System.Windows.Forms.TextBox txtCursorOpacity;
        private System.Windows.Forms.TextBox txtCursorSize;
        private System.Windows.Forms.TrackBar tbCursorSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCursorColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
    }
}