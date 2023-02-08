using Frostybee.MouseDecorator.Core;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NativeTextRenderer;

namespace Frostybee.MouseDecorator
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly MouseDecorationManager _applicationManager;        
        
        public MainForm()
        {
            InitializeComponent();
            // TODO: find the best value to autoscale with.
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96f, 96f);            
            // Clean up resources on application exit.
            Application.ApplicationExit += Application_ApplicationExit;

            //-- Set up the form closing/loading events. They are required for ensuring that 
            // the mouse hooks is properly installed/uninstalled.
            this.Load += MainForm_Load;
            // Init the managers.
            _applicationManager = MouseDecorationManager.Instance;               
            _materialSkinManager = MaterialSkinManager.Instance;
            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
                Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            // Internal events.
            //pbPreview.Paint += HighlighterPreview_Paint;
            //             
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            _applicationManager.SettingsManager.SaveHighlighterSettings();
            _applicationManager?.DisableHook();
            _applicationManager?.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _applicationManager.BootstrapApp();                     
            tabHighlighterSettings.InitHighlighterControls();
            Debug.WriteLine("MainForm_Load....");
        }        
    }
}
