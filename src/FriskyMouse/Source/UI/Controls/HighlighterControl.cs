using FriskyMouse.Core;
using FriskyMouse.Drawing.Helpers;
using FriskyMouse.Helpers;
using FriskyMouse.Settings;
using FriskyMouse.Extensions;
using FriskyMouse.Drawing.Ripples;
using FriskyMouse.Drawing.Extensions;

namespace FriskyMouse.UI.Controls
{
    public partial class HighlighterControl : UserControl
    {
        private readonly HighlighterOptions _settings;
        private readonly DecorationController _decorationManager;

        public HighlighterControl()
        {
            InitializeComponent();
            //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            _decorationManager = DecorationController.Instance;
            _settings = SettingsManager.Settings.HighlighterOptions;
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
            btnSpotlightColor.BackColor = _settings.FillColor;
            //-- Outline
            sldOutlineWidth.Value = _settings.OutlineWidth;
            btnOutlineColorPicker.BackColor = _settings.OutlineColor;
            switchShowOutline.Checked = _settings.IsOutlined;
            cmboxOutlineStyle.PopulateFromEnum<OutlineStyle>();
            cmboxOutlineStyle.SelectedIndex = cmboxOutlineStyle.GetItemIndexByEumValue(_settings.OutlineStyle);
            //-- Shadow
            switchShadow.Checked = _settings.HasShadow;
            sldShadowDepth.Value = _settings.ShadowDepth;
            btnCurrentShadowColor.BackColor = _settings.ShadowColor;
            sldShadowOpacity.Value = _settings.ShadowOpacityPercentage;
            //--             
            InitControlsEvents();
            UpdateOutlineSettings();
            AppHelpers.UpdateSwitchText(switchHighlighter);
            pboxPreview.Invalidate();
        }

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            _decorationManager.ApplyHighlighterSettings();
        }

        private void SwitchHighlighter_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Enabled = switchHighlighter.Checked;
            AppHelpers.UpdateSwitchText(switchHighlighter);
            if (switchHighlighter.Checked)
            {
                _decorationManager.EnableHighlighter();
            }
            else
            {
                _decorationManager.DisableHighlighter();
            }
        }

        private void UpdateOutlineSettings()
        {
            /*sldOutlineWidth.Enabled = !switchFilledSpotlight.Checked;
            cmboxOutlineStyle.Enabled = !switchFilledSpotlight.Checked;*/
        }

        private void OutlineStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            OutlineStyle selectedStyle = cmboxOutlineStyle.GetSelectedEnumValue<OutlineStyle>();
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
            Color selectedColor = Helpers.AppHelpers.GetUserSelectedColor(_settings.FillColor);
            _settings.FillColor = selectedColor;
            btnSpotlightColor.BackColor = selectedColor;
            UpdateHighlighterPreview();
        }
        private void BtnStrokeColor_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.AppHelpers.GetUserSelectedColor(_settings.OutlineColor);
            _settings.OutlineColor = selectedColor;
            UpdateHighlighterPreview();
            btnOutlineColorPicker.BackColor = selectedColor;
        }
        private void BtnShadow_Click(object sender, EventArgs e)
        {
            Color selectedColor = Helpers.AppHelpers.GetUserSelectedColor(_settings.ShadowColor);
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
            btnSpotlightColor.BackColor = Color.Yellow;
            _settings.FillColor = Color.Yellow;
            _settings.OutlineColor = Color.Red;
            _settings.OutlineWidth = 3;
            _settings.IsOutlined = true;
            _settings.ShadowDepth = 4;
            _settings.ShadowOpacityPercentage = 25;
            sldOutlineWidth.Value = _settings.OutlineWidth;
            sldShadowDepth.Value = _settings.ShadowDepth;
            sldShadowOpacity.Value = _settings.ShadowOpacityPercentage;
            switchFilledSpotlight.Checked = true;
            switchShowOutline.Checked = false;
            switchShadow.Checked = false;

            UpdateHighlighterPreview();
            _decorationManager.ApplyHighlighterSettings();
        }
    }
}
