using Bee.MouseDecorator.Core;
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
        private readonly CursorHighlighter circle = new CursorHighlighter();
        private MouseDecorationManager decorationManager;
        public MainForm()
        {
            InitializeComponent();
            // TODO: find the best value to autoscale with.
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96f, 96f);
            //-- Set up the form closing/loading events. They are required for ensuring that 
            // the mouse hooks is properly installed/uninstalled.
            this.FormClosing += MainForm_FormClosing;
            this.Activated += MainForm_Load;
            // Init members.
            decorationManager = MouseDecorationManager.Instance;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            decorationManager?.EnableHook();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            decorationManager?.DisableHook();
            decorationManager?.Dispose();
        }
    }
}
