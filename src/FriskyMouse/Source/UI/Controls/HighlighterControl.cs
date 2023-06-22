using FriskyMouse.Core;
using FriskyMouse.Drawing.Helpers;
using FriskyMouse.Settings;
using System.Drawing.Drawing2D;
using System.Runtime;

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
            //UpdateOutlineSettings();
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
            switchShowOutline.CheckedChanged += SwitchShowOutline_CheckedChanged;
            pboxPreview.Paint += HighlighterPreview_Paint;
            switchShadow.CheckedChanged += SwitchShadow_CheckedChanged;
            pboxPreview.BackgroundImage = Properties.Resources.sample_text;

        }

        internal void UpdateControlsFromSettings()
        {
            // Initialize the UI controls with the previously selected settings.            
            switchFilledSpotlight.Checked = _settings.IsFilled;
            sldRadius.Value = _settings.Radius;
            sldOpacity.Value = _settings.OpacityPercentage;
            sldOutlineWidth.Value = _settings.OutlineWidth;
            btnFillColorBck.BackColor = _settings.FillColor;
            btnOutlineColorCk.BackColor = _settings.OutlineColor;
            switchHighlighter.Checked = _settings.Enabled;
            switchShowOutline.Checked = _settings.IsOutlined;
            switchShadow.Checked = _settings.HasShadow;
            InitControlsEvents();
            UpdateOutlineSettings();
            UpdateHighlighterSwitchText();
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

        private void UpdateOutlineSettings()
        {
            /*sldOutlineWidth.Enabled = !switchFilledSpotlight.Checked;
            cmboxOutlineStyle.Enabled = !switchFilledSpotlight.Checked;*/
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
            UpdateOutlineSettings();
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
            _settings.OutlineWidth = sldOutlineWidth.Value;
            _settings.IsOutlined = switchShowOutline.Checked;
            pboxPreview.Invalidate();
        }
        private void HighlighterPreview_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = DrawingHelper.CreateRectangle(pboxPreview.Width, pboxPreview.Height, _settings.Radius);
            e.Graphics.DrawHighlighter(rect, _settings);
        }

        private void BtnFillColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.Helpers.GetUserSelectedColor(_settings.FillColor);
            _settings.FillColor = selectedColor;
            UpdateHighlighterPreview();
            btnFillColorBck.BackColor = selectedColor;

        }
        private void BtnStrokeColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.Helpers.GetUserSelectedColor(_settings.OutlineColor);
            _settings.OutlineColor = selectedColor;
            UpdateHighlighterPreview();
            btnOutlineColorCk.BackColor = selectedColor;
        }
        private void SwitchShadow_CheckedChanged(object sender, EventArgs e)
        {
            _settings.HasShadow = switchShadow.Checked;
            UpdateHighlighterPreview();
        }

        private void SwitchShowOutline_CheckedChanged(object sender, EventArgs e)
        {
            _settings.IsOutlined = switchShowOutline.Checked;
            UpdateHighlighterPreview();
        }

        /// <summary>
        /// Resets the highlighter settings to predefined values.
        /// - The spotlight radius will be reset to 15px.
        /// - The color will be reset to yellow.        
        /// - The color opacity will reset to 75%.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetHighlighter_Click(object sender, EventArgs e)
        {
            sldRadius.Value = 15;
            sldOpacity.Value = 75;
            btnFillColorBck.BackColor = Color.Yellow;
            _settings.FillColor = Color.Yellow;
            _settings.OutlineColor = Color.Red;
            _settings.OutlineStyle = DashStyle.Solid;
            switchFilledSpotlight.Checked = true;
            UpdateHighlighterPreview();
            _applicationManager.ApplyHighlighterSettings();
        }
    }
}
