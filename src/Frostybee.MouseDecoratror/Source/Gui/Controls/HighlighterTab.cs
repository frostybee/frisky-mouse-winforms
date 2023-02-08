using Frostybee.MouseDecorator.Core;

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

namespace Frostybee.MouseDecorator.Controls
{
    //TODO: might need to move all the controls back to the MainForm. 
    // Not sure if I can manage the hook from here since I need enable the hook upon loading 
    // the main form. 
    public partial class HighlighterTab : UserControl
    {
        private readonly HighlighterSettings _highlighterSettings;
        private readonly MouseDecorationManager _applicationManager;
        private readonly Dictionary<String, DashStyle> _outlineStyles = new Dictionary<String, DashStyle>() {
            { "Solid", DashStyle.Solid},
            { "Dash", DashStyle.Dash},
            { "Dot", DashStyle.Dot},
            { "Dash Dot", DashStyle.DashDot},
            { "Dash Dot Dot", DashStyle.DashDotDot},
        };
        public HighlighterTab()
        {
            InitializeComponent();
            _applicationManager = MouseDecorationManager.Instance;
            _highlighterSettings = _applicationManager.SettingsManager.HighlighterSettings;

            // TODO: 1) must load the saved settings first.
            //       2) Setup UI controls based on the loaded settings.
            InitControlsEvents();
            // Enable the slider of the _highlighterSettings's outline width based 
            // on the status of the fill circle switch.
            ManageOutlineSettings();
        }

        private void InitControlsEvents()
        {
            //-- Sliders events
            sldRadius.onValueChanged += OpacityOrRadius_onValueChanged;
            sldOpacity.onValueChanged += OpacityOrRadius_onValueChanged;
            sldOutlineWidth.onValueChanged += OutlineThickness_onValueChanged;
            //-- Switch events
            switchFilledColor.CheckedChanged += SwitchFilledColor_CheckedChanged;
            switchHighlighter.CheckedChanged += SwitchHighlighter_CheckedChanged;
            cbOutlineStyle.SelectedValueChanged += OutlineStyle_SelectedValueChanged;
            pbPreview.Paint += HighlighterPreview_Paint;
        }

        internal void InitHighlighterControls()
        {
            // Initialize the UI controls with the previously selected settings.            
            switchFilledColor.Checked = _highlighterSettings.IsFilled;
            sldRadius.Value = _highlighterSettings.Radius;
            sldOpacity.Value = _highlighterSettings.Opacity;
            sldOutlineWidth.Value = _highlighterSettings.OutlineThickness;
            btnColorPicker.BackColor = _highlighterSettings.FillColor;
            switchHighlighter.Checked = _highlighterSettings.IsEnabled;
            // TODO: init the outline style in the combo box.
            // FIXME: 
            // TODO: If highlighter disabled ===> Disable the controls. 

            // TODO: draw the preview.
            pbPreview.Invalidate();
        }

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            _applicationManager.ApplyHighlighterSettings();
        }

        private void SwitchHighlighter_CheckedChanged(object sender, EventArgs e)
        {
            _highlighterSettings.IsEnabled = switchHighlighter.Checked;
            if (switchHighlighter.Checked)
            {
                MouseDecorationManager.Instance.EnableHighlighter();
            }
            else
            {
                // TODO: upon disabling the hook,
                // the layered window should be hidden.                
                MouseDecorationManager.Instance.DisableHook();
            }
        }

        private void ManageOutlineSettings()
        {
            sldOutlineWidth.Enabled = !switchFilledColor.Checked;
            cbOutlineStyle.Enabled = !switchFilledColor.Checked;
        }

        private void OutlineStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: move to a helper method in a separeate helper class.
            // Convert the selected style from text to it's corresponding enum value.
            // FIXME: the list should be saved in a dictionary.            
            var selectedStyle = DashStyle.Solid;
            _outlineStyles.TryGetValue(cbOutlineStyle.SelectedItem.ToString(), out selectedStyle);
            _highlighterSettings.OutlineStyle = selectedStyle;
            UpdateHighlighterPreview();
        }

        private void OutlineThickness_onValueChanged(object sender, int newValue)
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
            _highlighterSettings.CenterX = pbPreview.Width / 2;
            _highlighterSettings.CenterY = pbPreview.Width / 2;
            _highlighterSettings.IsFilled = switchFilledColor.Checked;
            _highlighterSettings.Radius = sldRadius.Value;
            _highlighterSettings.Opacity = (byte)sldOpacity.Value;
            _highlighterSettings.OutlineThickness = sldOutlineWidth.Value;
            pbPreview.Invalidate();
        }
        private void HighlighterPreview_Paint(object sender, PaintEventArgs e)
        {
            _highlighterSettings.Draw(e.Graphics);
        }

        private void ColorPicker_Click(object sender, EventArgs e)
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
                _highlighterSettings.FillColor = colorPicker.Color;
                UpdateHighlighterPreview();
                btnColorPicker.BackColor = colorPicker.Color;
            }
        }
    }
}
