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
    public partial class HighlighterControl : UserControl
    {
        private readonly HighlighterSettings _highlighterModel;
        private readonly MouseDecorationManager _applicationManager;
        private readonly Dictionary<String, DashStyle> _outlineStyles = new Dictionary<String, DashStyle>() {
            { "Solid", DashStyle.Solid},
            { "Dash", DashStyle.Dash},
            { "Dot", DashStyle.Dot},
            { "Dash Dot", DashStyle.DashDot},
            { "Dash Dot Dot", DashStyle.DashDotDot},
        };
        public HighlighterControl()
        {
            InitializeComponent();
            _applicationManager = MouseDecorationManager.Instance;
            _highlighterModel = _applicationManager.SettingsManager.HighlighterSettings;

            // TODO: 1) must load the saved settings first.
            //       2) Setup UI controls based on the loaded settings.
            InitControlsEvents();
            // Enable the slider of the _highlighterModel's outline width based 
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
            cmboxOutlineStyle.SelectedValueChanged += OutlineStyle_SelectedValueChanged;
            pboxPreview.Paint += HighlighterPreview_Paint;
        }

        internal void InitHighlighterControls()
        {
            // Initialize the UI controls with the previously selected settings.            
            switchFilledColor.Checked = _highlighterModel.IsFilled;
            sldRadius.Value = _highlighterModel.Radius;
            sldOpacity.Value = _highlighterModel.OpacityPercentage;            
            sldOutlineWidth.Value = _highlighterModel.OutlineThickness;
            //MessageBox.Show(sldOutlineWidth.Value.ToString());
            btnColorPicker.BackColor = _highlighterModel.FillColor;
            switchHighlighter.Checked = _highlighterModel.IsEnabled;
            // TODO: init the outline style in the combo box.
            // FIXME: 
            // TODO: If highlighter disabled ===> Disable the controls. 

            // TODO: draw the preview.
            pboxPreview.Invalidate();
        }

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            _applicationManager.ApplyHighlighterSettings();
        }

        private void SwitchHighlighter_CheckedChanged(object sender, EventArgs e)
        {
            _highlighterModel.IsEnabled = switchHighlighter.Checked;
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
            cmboxOutlineStyle.Enabled = !switchFilledColor.Checked;
        }

        private void OutlineStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: move to a helper method in a separate helper class.
            // Convert the selected style from text to it's corresponding enum value.
            // FIXME: the list should be saved in a dictionary.            
            var selectedStyle = DashStyle.Solid;
            _outlineStyles.TryGetValue(cmboxOutlineStyle.SelectedItem.ToString(), out selectedStyle);
            _highlighterModel.OutlineStyle = selectedStyle;
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
            _highlighterModel.CenterX = pboxPreview.Width / 2;
            _highlighterModel.CenterY = pboxPreview.Width / 2;
            _highlighterModel.IsFilled = switchFilledColor.Checked;
            _highlighterModel.Radius = sldRadius.Value;
            _highlighterModel.OpacityPercentage = (byte)sldOpacity.Value;            
            _highlighterModel.OutlineThickness = sldOutlineWidth.Value;
            pboxPreview.Invalidate();
        }
        private void HighlighterPreview_Paint(object sender, PaintEventArgs e)
        {
            _highlighterModel.IsForPreview = true;
            _highlighterModel.Draw(e.Graphics);
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
                _highlighterModel.FillColor = colorPicker.Color;
                UpdateHighlighterPreview();
                btnColorPicker.BackColor = colorPicker.Color;
            }
        }
    }
}
