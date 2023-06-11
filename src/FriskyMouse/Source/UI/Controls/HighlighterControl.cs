using FriskyMouse.Core;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FriskyMouse.UI.Controls
{
    //TODO: might need to move all the controls back to the MainForm. 
    // Not sure if I can manage the hook from here since I need enable the hook upon loading 
    // the main form. 
    public partial class HighlighterControl : UserControl
    {
        private readonly HighlighterInfo _highlighter;
        private readonly DecorationController _applicationManager;
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
            //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            _applicationManager = DecorationController.Instance;
            _highlighter = _applicationManager.SettingsManager.HighlighterSettings;

            // TODO: 1) must load the saved settings first.
            //       2) Setup UI controls based on the loaded settings.
            InitControlsEvents();
            // Enable the slider of the _highlighter's outline width based 
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
            switchFilledSpotlight.CheckedChanged += SwitchFilledColor_CheckedChanged;
            switchHighlighter.CheckedChanged += SwitchHighlighter_CheckedChanged;
            cmboxOutlineStyle.SelectedValueChanged += OutlineStyle_SelectedValueChanged;
            pboxPreview.Paint += HighlighterPreview_Paint;
            pboxPreview.BackgroundImage = Properties.Resources.sample_text;

        }

        internal void InitHighlighterControls()
        {
            // Initialize the UI controls with the previously selected settings.            
            switchFilledSpotlight.Checked = _highlighter.IsFilled;
            sldRadius.Value = _highlighter.Radius;
            sldOpacity.Value = _highlighter.OpacityPercentage;
            sldOutlineWidth.Value = _highlighter.OutlineThickness;
            //sldOutlineWidth.Value =  5;
            //_highlighter.OutlineThickness = 15;
            //MessageBox.Show(_highlighter.OutlineThickness.ToString());
            btnColorPicker.BackColor = _highlighter.FillColor;
            switchHighlighter.Checked = _highlighter.Enabled;
            UpdateHighlighterSwitchText();
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
            _highlighter.Enabled = switchHighlighter.Checked;
            // Ajust the test of the switch.
            UpdateHighlighterSwitchText();
            if (switchHighlighter.Checked)
            {
                DecorationController.Instance.EnableHighlighter();
            }
            else
            {
                // TODO: upon disabling the hook,
                // the layered window should be hidden.                
                //DecorationController.Instance.DisableHook();
            }
            DecorationController.Instance.DisableHighlighter();
        }

        private void UpdateHighlighterSwitchText()
        {
            switchHighlighter.Text = (switchHighlighter.Checked) ? "On" : "Off";
        }

        private void ManageOutlineSettings()
        {
            sldOutlineWidth.Enabled = !switchFilledSpotlight.Checked;
            cmboxOutlineStyle.Enabled = !switchFilledSpotlight.Checked;
        }

        private void OutlineStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: move to a helper method in a separate helper class.
            // Convert the selected style from text to it's corresponding enum value.
            // FIXME: the list should be saved in a dictionary.            
            var selectedStyle = DashStyle.Solid;
            _outlineStyles.TryGetValue(cmboxOutlineStyle.SelectedItem.ToString(), out selectedStyle);
            _highlighter.OutlineStyle = selectedStyle;
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
            _highlighter.CenterX = pboxPreview.Width / 2;
            _highlighter.CenterY = pboxPreview.Width / 2;
            _highlighter.IsFilled = switchFilledSpotlight.Checked;
            _highlighter.Radius = sldRadius.Value;
            _highlighter.OpacityPercentage = (byte)sldOpacity.Value;
            _highlighter.OutlineThickness = sldOutlineWidth.Value;
            pboxPreview.Invalidate();
        }
        private void HighlighterPreview_Paint(object sender, PaintEventArgs e)
        {
            _highlighter.IsForPreview = true;
            _highlighter.Draw(e.Graphics);
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
                _highlighter.FillColor = colorPicker.Color;
                UpdateHighlighterPreview();
                btnColorPicker.BackColor = colorPicker.Color;
            }
        }

        /// <summary>
        /// Resets the highlighter settings to predefined values.
        /// - The spotlight radius will be reset to 15px.
        /// - The color will be reset to yellow.        
        /// - The color opacity will reset to 75%.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetSettings_Click(object sender, EventArgs e)
        {
            sldRadius.Value = 15;
            sldOpacity.Value = 75;
            btnColorPicker.BackColor = Color.Yellow;
            _highlighter.FillColor = Color.Yellow;
            switchFilledSpotlight.Checked = true;
            UpdateHighlighterPreview();
            _applicationManager.ApplyHighlighterSettings();
        }
    }
}
