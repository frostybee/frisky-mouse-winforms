using FriskyMouse.Core;
using FriskyMouse.HelpersLib.Helpers;
using FriskyMouse.Settings;
using System.Drawing.Drawing2D;

namespace FriskyMouse.UI.Controls
{
    //TODO: might need to move all the controls back to the MainForm. 
    // Not sure if I can manage the hook from here since I need enable the hook upon loading 
    // the main form. 
    public partial class HighlighterControl : UserControl
    {
        private readonly HighlighterOptions _settings;
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
            _settings = SettingsManager.Settings.HighlighterOptions;                       
            // Enable the slider of the _settings's outline width based 
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

        internal void InitControlsFromSettings()
        {
            // Initialize the UI controls with the previously selected settings.            
            switchFilledSpotlight.Checked = _settings.IsFilled;
            sldRadius.Value = _settings.Radius;
            sldOpacity.Value = _settings.OpacityPercentage;
            sldOutlineWidth.Value = _settings.OutlineThickness;
            //sldOutlineWidth.Value =  5;
            //_settings.OutlineThickness = 15;
            //MessageBox.Show(_settings.OutlineThickness.ToString());
            btnColorPicker.BackColor = _settings.FillColor;
            switchHighlighter.Checked = _settings.Enabled;
            // TODO: 1) must load the saved settings first.
            //       2) Setup UI controls based on the loaded settings.
            InitControlsEvents();
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
            _settings.Enabled = switchHighlighter.Checked;            
            UpdateHighlighterSwitchText();
            if (switchHighlighter.Checked)
            {
                _applicationManager.EnableHighlighter();
            }
            else
            {
                _applicationManager.DisableHighlighter();
            }
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
            _settings.OutlineStyle = selectedStyle;
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
            _settings.IsFilled = switchFilledSpotlight.Checked;
            _settings.Radius = sldRadius.Value;
            _settings.OpacityPercentage = (byte)sldOpacity.Value;
            _settings.OutlineThickness = sldOutlineWidth.Value;
            pboxPreview.Invalidate();
        }
        private void HighlighterPreview_Paint(object sender, PaintEventArgs e)
        {
            _settings.IsForPreview = true;
            Rectangle rect = DrawingHelper.CreateRectangle(pboxPreview.Width, pboxPreview.Height, _settings.Radius);
            e.Graphics.DrawSpotlight(rect, _settings);
        }

        private void BtnColorPicker_Click(object sender, EventArgs e)
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
                _settings.FillColor = colorPicker.Color;
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
            _settings.FillColor = Color.Yellow;
            switchFilledSpotlight.Checked = true;
            UpdateHighlighterPreview();
            _applicationManager.ApplyHighlighterSettings();
        }
    }
}
