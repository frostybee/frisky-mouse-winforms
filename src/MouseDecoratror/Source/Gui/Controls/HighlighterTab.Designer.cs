namespace MouseDecoratror.Controls
{
    partial class HighlighterTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbOutlineStyle = new MaterialSkin.Controls.MaterialComboBox();
            this.sldOutlineWidth = new MaterialSkin.Controls.MaterialSlider();
            this.switchFilledColor = new MaterialSkin.Controls.MaterialSwitch();
            this.siwtchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.lblColor = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sldRadius = new MaterialSkin.Controls.MaterialSlider();
            this.sldOpacity = new MaterialSkin.Controls.MaterialSlider();
            this.switchHighlighter = new MaterialSkin.Controls.MaterialSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel26);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 462);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel26.Location = new System.Drawing.Point(4, 8);
            this.materialLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(537, 41);
            this.materialLabel26.TabIndex = 62;
            this.materialLabel26.Text = "Mouse Cursor - Highlighter Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbOutlineStyle);
            this.panel2.Controls.Add(this.sldOutlineWidth);
            this.panel2.Controls.Add(this.switchFilledColor);
            this.panel2.Controls.Add(this.siwtchHighlighter);
            this.panel2.Controls.Add(this.btnColorPicker);
            this.panel2.Controls.Add(this.lblColor);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.sldRadius);
            this.panel2.Controls.Add(this.sldOpacity);
            this.panel2.Controls.Add(this.switchHighlighter);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 344);
            this.panel2.TabIndex = 61;
            // 
            // cbOutlineStyle
            // 
            this.cbOutlineStyle.AutoResize = false;
            this.cbOutlineStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbOutlineStyle.Depth = 0;
            this.cbOutlineStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOutlineStyle.DropDownHeight = 174;
            this.cbOutlineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutlineStyle.DropDownWidth = 121;
            this.cbOutlineStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbOutlineStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbOutlineStyle.FormattingEnabled = true;
            this.cbOutlineStyle.Hint = "Outline style";
            this.cbOutlineStyle.IntegralHeight = false;
            this.cbOutlineStyle.ItemHeight = 43;
            this.cbOutlineStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cbOutlineStyle.Location = new System.Drawing.Point(25, 285);
            this.cbOutlineStyle.Margin = new System.Windows.Forms.Padding(4);
            this.cbOutlineStyle.MaxDropDownItems = 4;
            this.cbOutlineStyle.MouseState = MaterialSkin.MouseState.OUT;
            this.cbOutlineStyle.Name = "cbOutlineStyle";
            this.cbOutlineStyle.Size = new System.Drawing.Size(252, 49);
            this.cbOutlineStyle.StartIndex = 0;
            this.cbOutlineStyle.TabIndex = 72;
            this.cbOutlineStyle.UseAccent = false;
            // 
            // sldOutlineWidth
            // 
            this.sldOutlineWidth.Depth = 0;
            this.sldOutlineWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldOutlineWidth.Location = new System.Drawing.Point(25, 245);
            this.sldOutlineWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldOutlineWidth.Name = "sldOutlineWidth";
            this.sldOutlineWidth.RangeMax = 15;
            this.sldOutlineWidth.RangeMin = 1;
            this.sldOutlineWidth.Size = new System.Drawing.Size(252, 40);
            this.sldOutlineWidth.TabIndex = 15;
            this.sldOutlineWidth.Text = "Outline Thickness";
            this.sldOutlineWidth.Value = 1;
            this.sldOutlineWidth.ValueSuffix = "px";
            // 
            // switchFilledColor
            // 
            this.switchFilledColor.AutoSize = true;
            this.switchFilledColor.Checked = true;
            this.switchFilledColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchFilledColor.Depth = 0;
            this.switchFilledColor.Location = new System.Drawing.Point(12, 205);
            this.switchFilledColor.Margin = new System.Windows.Forms.Padding(0);
            this.switchFilledColor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchFilledColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchFilledColor.Name = "switchFilledColor";
            this.switchFilledColor.Ripple = true;
            this.switchFilledColor.Size = new System.Drawing.Size(139, 37);
            this.switchFilledColor.TabIndex = 14;
            this.switchFilledColor.Text = "Filled Circle";
            this.switchFilledColor.UseVisualStyleBackColor = true;
            // 
            // siwtchHighlighter
            // 
            this.siwtchHighlighter.AutoSize = true;
            this.siwtchHighlighter.Depth = 0;
            this.siwtchHighlighter.Location = new System.Drawing.Point(12, 4);
            this.siwtchHighlighter.Margin = new System.Windows.Forms.Padding(0);
            this.siwtchHighlighter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.siwtchHighlighter.MouseState = MaterialSkin.MouseState.HOVER;
            this.siwtchHighlighter.Name = "siwtchHighlighter";
            this.siwtchHighlighter.Ripple = true;
            this.siwtchHighlighter.Size = new System.Drawing.Size(233, 37);
            this.siwtchHighlighter.TabIndex = 13;
            this.siwtchHighlighter.Text = "Mouse CursorHighlighter";
            this.siwtchHighlighter.UseVisualStyleBackColor = true;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPicker.Location = new System.Drawing.Point(94, 153);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(87, 27);
            this.btnColorPicker.TabIndex = 12;
            this.btnColorPicker.Text = "...";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Depth = 0;
            this.lblColor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblColor.Location = new System.Drawing.Point(9, 158);
            this.lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(38, 19);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(396, 281);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(65, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Reset";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(480, 281);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(67, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Apply";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 2);
            this.label1.TabIndex = 8;
            // 
            // sldRadius
            // 
            this.sldRadius.Depth = 0;
            this.sldRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldRadius.Location = new System.Drawing.Point(12, 111);
            this.sldRadius.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldRadius.Name = "sldRadius";
            this.sldRadius.Size = new System.Drawing.Size(255, 40);
            this.sldRadius.TabIndex = 5;
            this.sldRadius.Text = "Radius  ";
            this.sldRadius.Value = 100;
            this.sldRadius.ValueSuffix = "px";
            // 
            // sldOpacity
            // 
            this.sldOpacity.Depth = 0;
            this.sldOpacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sldOpacity.Location = new System.Drawing.Point(12, 65);
            this.sldOpacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.sldOpacity.Name = "sldOpacity";
            this.sldOpacity.RangeMax = 255;
            this.sldOpacity.RangeMin = 50;
            this.sldOpacity.Size = new System.Drawing.Size(255, 40);
            this.sldOpacity.TabIndex = 4;
            this.sldOpacity.Text = "Opacity  ";
            this.sldOpacity.Value = 100;
            this.sldOpacity.ValueSuffix = "%";
            // 
            // switchHighlighter
            // 
            this.switchHighlighter.AutoSize = true;
            this.switchHighlighter.Depth = 0;
            this.switchHighlighter.Location = new System.Drawing.Point(12, 4);
            this.switchHighlighter.Margin = new System.Windows.Forms.Padding(0);
            this.switchHighlighter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchHighlighter.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchHighlighter.Name = "switchHighlighter";
            this.switchHighlighter.Ripple = true;
            this.switchHighlighter.Size = new System.Drawing.Size(181, 37);
            this.switchHighlighter.TabIndex = 0;
            this.switchHighlighter.Text = "CursorHighlighter";
            this.switchHighlighter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Location = new System.Drawing.Point(309, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(16, 28);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(194, 149);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // HighlighterTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HighlighterTab";
            this.Size = new System.Drawing.Size(970, 462);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSlider sldRadius;
        private MaterialSkin.Controls.MaterialSlider sldOpacity;
        private MaterialSkin.Controls.MaterialSwitch switchHighlighter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPreview;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorPicker;
        private MaterialSkin.Controls.MaterialSwitch switchFilledColor;
        private MaterialSkin.Controls.MaterialSwitch siwtchHighlighter;
        private MaterialSkin.Controls.MaterialSlider sldOutlineWidth;
        private MaterialSkin.Controls.MaterialComboBox cbOutlineStyle;
    }
}
