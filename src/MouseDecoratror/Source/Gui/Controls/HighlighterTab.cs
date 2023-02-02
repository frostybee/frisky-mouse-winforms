using Bee.MouseDecorator.Core;
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

namespace MouseDecoratror.Controls
{
    //TODO: might need to move all the controls back to the MainForm. 
    // Not sure if I can manage the hook from here since I need enable the hook upon loading 
    // the main form. 
    public partial class HighlighterTab : UserControl
    {
        private readonly CursorHighlighter highlighter = new CursorHighlighter();
        private readonly Dictionary<String, DashStyle> outlineStyles = new Dictionary<String, DashStyle>() {
            { "Solid", DashStyle.Solid},
            { "Dash", DashStyle.Dash},
            { "Dot", DashStyle.Dot},
            { "Dash Dot", DashStyle.DashDot},
            { "Dash Dot Dot", DashStyle.DashDotDot},
        };
        public HighlighterTab()
        {
            InitializeComponent();
            //-- Sliders events
            sldRadius.onValueChanged += OpacityOrRadius_onValueChanged;
            sldOpacity.onValueChanged += OpacityOrRadius_onValueChanged;
            sldOutlineWidth.onValueChanged += SldOutlineWidth_onValueChanged;
            // Switch events
            switchFilledColor.CheckedChanged += SwitchFilledColor_CheckedChanged;
            switchHighlighter.CheckedChanged += SwitchHighlighter_CheckedChanged;
            cbOutlineStyle.SelectedValueChanged += CbOutlineStyle_SelectedValueChanged;
            pbPreview.Paint += PbPreview_Paint;

            // TODO: 1) must load the saved settings first.
            //       2) Setup UI controls based on the loaded settings.

            // Enable the slider of the highlighter's outline width based 
            // on the status of the fill circle switch.
            ManageOutlineSettings();            
        }

        private void SwitchHighlighter_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            if (switchHighlighter.Checked)
            {
                MessageBox.Show("Test");
                MouseDecorationManager.Instance.DisableHook();
            }
            else
            {
                MouseDecorationManager.Instance.EnableHook();
            }
            
        }

        private void ManageOutlineSettings()
        {
            sldOutlineWidth.Enabled = !switchFilledColor.Checked;
            cbOutlineStyle.Enabled = !switchFilledColor.Checked;
        }

        private void CbOutlineStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: move to a helper method in a separeate helper class.
            // Convert the selected style from text to it's corresponding enum value.
            // FIXME: the list should be saved in a dictionary.            
            var selectedStyle = DashStyle.Solid;
            outlineStyles.TryGetValue(cbOutlineStyle.SelectedItem.ToString(), out selectedStyle);
            highlighter.OutlineStyle = selectedStyle;           
            UpdateHighlighterPreview();
        }

        private void SldOutlineWidth_onValueChanged(object sender, int newValue)
        {
            UpdateHighlighterPreview();
        }

        private void SwitchFilledColor_CheckedChanged(object sender, EventArgs e)
        {            
            ManageOutlineSettings();
            UpdateHighlighterPreview();
        }

        private void OpacityOrRadius_onValueChanged(object sender, int newValue)
        {
            UpdateHighlighterPreview();
        }

        private void UpdateHighlighterPreview()
        {
            highlighter.CenterX = pbPreview.Width /2; 
            highlighter.CenterY = pbPreview.Width/2;
            highlighter.IsFilled = switchFilledColor.Checked;
            highlighter.Radius = sldRadius.Value;
            highlighter.Opacity = sldOpacity.Value;
            highlighter.OutlineWidth = sldOutlineWidth.Value;
            pbPreview.Invalidate();
        }
        private void PbPreview_Paint(object sender, PaintEventArgs e)
        {
            highlighter.Draw(e.Graphics);
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorPicker.AllowFullOpen = true;
            colorPicker.FullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorPicker.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorPicker.Color = btnColorPicker.BackColor;

            // Update the text box color if the user clicks OK 
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                highlighter.FillColor = colorPicker.Color;
                UpdateHighlighterPreview();
                btnColorPicker.BackColor = colorPicker.Color;
            }
        }
    }
}
