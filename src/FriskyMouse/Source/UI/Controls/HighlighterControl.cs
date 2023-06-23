using FriskyMouse.Core;
using FriskyMouse.Drawing.Helpers;
using FriskyMouse.Settings;

namespace FriskyMouse.UI.Controls
{
    //TODO: might need to move all the controls back to the MainForm. 
    // Not sure if I can manage the hook from here since I need enable the hook upon loading 
    // the main form. 
    public partial class HighlighterControl : UserControl
    {
        private readonly HighlighterOptions _settings;
        private readonly DecorationController _decorationManager;
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
            _decorationManager = DecorationController.Instance;
            _settings = SettingsManager.Settings.HighlighterOptions;
            // Enable the slider of the _settings's outline width based 
            // on the status of the fill circle switch.
            //UpdateOutlineSettings();
        }

        private void InitControlsEvents()
        {
            //-- Spotlight
            sldRadius.onValueChanged += OpacityOrRadius_onValueChanged;
            sldOpacity.onValueChanged += OpacityOrRadius_onValueChanged;
            switchFilledSpotlight.CheckedChanged += SwitchFilledColor_CheckedChanged;
            switchHighlighter.CheckedChanged += SwitchHighlighter_CheckedChanged;
            //-- Shadow
            sldShadowDepth.onValueChanged += SldShadowDepth_onValueChanged;
            sldShadowOpacity.onValueChanged += OpacityOrRadius_onValueChanged;
            switchShadow.CheckedChanged += SwitchShadow_CheckedChanged;
            //-- Outline
            switchShowOutline.CheckedChanged += SwitchShowOutline_CheckedChanged;
            sldOutlineWidth.onValueChanged += OutlineThickness_onValueChanged;
            cmboxOutlineStyle.SelectedValueChanged += OutlineStyle_SelectedValueChanged;
            //-- Preview
            pboxPreview.Paint += HighlighterPreview_Paint;
            pboxPreview.BackgroundImage = Properties.Resources.Sample_Text_IMG;
        }

        /// <summary>
        /// Initializes the contained controls with the previously selected settings.            
        /// This action must be performed before adding events to their respective controls.
        /// </summary>
        internal void UpdateControlsFromSettings()
        {
            //-- Spotlight
            switchFilledSpotlight.Checked = _settings.IsFilled;
            sldRadius.Value = _settings.Radius;
            sldOpacity.Value = _settings.OpacityPercentage;
            switchHighlighter.Checked = _settings.Enabled;
            lblFillColor.BackColor = _settings.FillColor;
            //-- Outline
            sldOutlineWidth.Value = _settings.OutlineWidth;
            btnOutlineColorPicker.BackColor = _settings.OutlineColor;
            switchShowOutline.Checked = _settings.IsOutlined;
            //-- Shadow
            switchShadow.Checked = _settings.HasShadow;
            sldShadowDepth.Value = _settings.ShadowDepth;
            btnCurrentShadowColor.BackColor = _settings.ShadowColor;
            sldShadowOpacity.Value = _settings.ShadowOpacityPercentage;
            //--             
            InitControlsEvents();
            UpdateOutlineSettings();
            UpdateHighlighterSwitchText();
            pboxPreview.Invalidate();
        }

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            _decorationManager.ApplyHighlighterSettings();
        }

        private void SwitchHighlighter_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Enabled = switchHighlighter.Checked;
            UpdateHighlighterSwitchText();
            if (switchHighlighter.Checked)
            {
                _decorationManager.EnableHighlighter();
            }
            else
            {
                _decorationManager.DisableHighlighter();
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
            if (sldOutlineWidth.Value < 1)
            {
                sldOutlineWidth.Value = 1;
            }
            UpdateHighlighterPreview();
        }

        private void SwitchFilledColor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutlineSettings();
            UpdateHighlighterPreview();
        }

        private void OpacityOrRadius_onValueChanged(object sender, int newValue)
        {
            if (sldRadius.Value < 10)
            {
                sldRadius.Value = 10;
            }
            if (sldOpacity.Value < 10)
            {
                sldOpacity.Value = 10;
            }
            if (sldShadowOpacity.Value < 10)
            {
                sldShadowOpacity.Value = 10;
            }
            UpdateHighlighterPreview();
        }

        private void UpdateHighlighterPreview()
        {
            _settings.IsFilled = switchFilledSpotlight.Checked;
            _settings.Radius = sldRadius.Value;
            _settings.OpacityPercentage = (byte)sldOpacity.Value;
            _settings.OutlineWidth = sldOutlineWidth.Value;
            _settings.IsOutlined = switchShowOutline.Checked;
            _settings.ShadowOpacityPercentage = (byte)sldShadowOpacity.Value;
            // Redraw the newly customized highlighter onto the layered window.
            _decorationManager.ApplyHighlighterSettings();
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
            lblFillColor.BackColor = selectedColor;
            UpdateHighlighterPreview();
        }
        private void BtnStrokeColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.Helpers.GetUserSelectedColor(_settings.OutlineColor);
            _settings.OutlineColor = selectedColor;
            UpdateHighlighterPreview();
            btnOutlineColorPicker.BackColor = selectedColor;
        }
        private void BtnShadow_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.Helpers.GetUserSelectedColor(_settings.ShadowColor);
            _settings.ShadowColor = selectedColor;
            btnCurrentShadowColor.BackColor = selectedColor;
            UpdateHighlighterPreview();
        }
        private void SwitchShadow_CheckedChanged(object sender, EventArgs e)
        {
            _settings.HasShadow = switchShadow.Checked;
            UpdateHighlighterPreview();
        }
        private void SldShadowDepth_onValueChanged(object sender, int newValue)
        {
            if (sldShadowDepth.Value < 2)
            {
                sldShadowDepth.Value = 2;

            }
            _settings.ShadowDepth = sldShadowDepth.Value;
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
            lblFillColor.BackColor = Color.Yellow;
            _settings.FillColor = Color.Yellow;
            _settings.OutlineColor = Color.Red;
            _settings.OutlineStyle = DashStyle.Dot;
            _settings.OutlineWidth = 3;
            _settings.IsOutlined = true;
            sldOutlineWidth.Value = _settings.OutlineWidth;
            switchFilledSpotlight.Checked = true;
            switchShowOutline.Checked = true;
            UpdateHighlighterPreview();
            _decorationManager.ApplyHighlighterSettings();
        }
    }
}
