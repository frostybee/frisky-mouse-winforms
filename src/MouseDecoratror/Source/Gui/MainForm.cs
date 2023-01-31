using MaterialSkin;
using MaterialSkin.Controls;
using MouseDecoratror.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NativeTextRenderer;

namespace MouseDecoratror
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly HighlightCircle circle = new HighlightCircle();        
        public MainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96f, 96f);
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
                Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            // Internal events.
            //pbPreview.Paint += PbPreview_Paint;
            //             
        }               
    }
}
