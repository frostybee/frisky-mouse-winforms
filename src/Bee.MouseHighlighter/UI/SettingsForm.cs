
using Bee.MouseDecorator.Core;
using System.Drawing;
using System.Windows.Forms;
using DecorationAppSettings = Bee.MouseHighlighter.Properties;

namespace Bee.MouseDecorator.UI
{
    public partial class MainForm : Form
    {
        
        private DecorationController decorationController;

        public MainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96f, 96f);
            //mHighlightForm = new HighlightForm(this);
            decorationController = DecorationController.Instance;
            //mClickHighlightForm = new LeftClickForm(this);
            FormClosing += MainForm_FormClosing;
            base.Activated += MainForm_Activated;
            base.Resize += MainForm_Resize;
            appNotifyIcon.DoubleClick += AppNotifyIcon_DoubleClick;
            txtCursorOpacity.Text = tbCursorOpacity.Value.ToString();
            txtCursorSize.Text = tbCursorSize.Value.ToString();
        }

        private void AppNotifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            this.Show();            
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            appNotifyIcon.Visible = false;            
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                appNotifyIcon.Visible = true;
                appNotifyIcon.ShowBalloonTip(1000);
                Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                appNotifyIcon.Visible = false;
            }
        }

        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            decorationController.EnableHook();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            decorationController?.DisableHook();
            decorationController?.Dispose();
        }

        private void SliderCursorOpacity_Scroll(object sender, System.EventArgs e)
        {
            txtCursorOpacity.Text = tbCursorOpacity.Value.ToString();
        }

        private void sliderCursorSize_Scroll(object sender, System.EventArgs e)
        {
            txtCursorSize.Text = tbCursorSize.Value.ToString();            
        }

        private void SelectCursorColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorPicker.AllowFullOpen = true;
            colorPicker.FullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorPicker.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorPicker.Color = btnCursorColor.BackColor;

            // Update the text box color if the user clicks OK 
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                btnCursorColor.BackColor = colorPicker.Color;
            }
        }
    }
}
