using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;

namespace FriskyMouse.Core
{
    internal class SettingsManager
    {
        private readonly HighlighterInfo _highlighterSettings = new();
        private readonly RippleProfileOptions _leftClickOptions = new();
        private readonly RippleProfileOptions _rightClickOptions = new();
        internal SettingsManager() { }

        internal void LoadAppSettings()
        {
            var settings = Properties.Settings.Default;
            // Load first the highlighter settings.            
            _highlighterSettings.Radius = settings.HighlighterRadius;
            _highlighterSettings.OpacityPercentage = settings.HighlighterOpacity;
            _highlighterSettings.FillColor = settings.HighlighterFillColor;
            _highlighterSettings.OutlineColor = settings.HighlighterOutlineColor;
            _highlighterSettings.IsFilled = settings.HighlighterIsFilled;
            _highlighterSettings.OutlineThickness = settings.HighlighterOutlineThickness;
            _highlighterSettings.OutlineStyle = settings.HighlighterOutlineStyle;
            _highlighterSettings.Enabled = settings.IsHighlighterEnabled;
            // Load the left click decoration settings.
            _leftClickOptions.AnimationDirection = (AnimationDirection)settings.ClickRippleAnimDirection;
            _leftClickOptions.AnimationSpeed = settings.ClickRippleSpeed;
            _leftClickOptions.InterpolationType = (InterpolationType)settings.ClickRippleEasingType;
            _leftClickOptions.Enabled = settings.ClickRippleEnabled;
            _leftClickOptions.CanFadeColor = settings.ClickRippleFadeColor;
            _leftClickOptions.CurrentRippleProfile = (RippleProfileType)settings.ClickRippleProfile;
        }

        internal void SaveDecorationSettings()
        {
            var settings = Properties.Settings.Default;
            settings.HighlighterRadius = _highlighterSettings.Radius;
            settings.HighlighterOpacity = _highlighterSettings.OpacityPercentage;
            settings.HighlighterFillColor = _highlighterSettings.FillColor;
            settings.HighlighterOutlineColor = _highlighterSettings.OutlineColor;
            settings.HighlighterIsFilled = _highlighterSettings.IsFilled;
            settings.HighlighterOutlineThickness = _highlighterSettings.OutlineThickness;
            settings.HighlighterOutlineStyle = _highlighterSettings.OutlineStyle;
            settings.IsHighlighterEnabled = _highlighterSettings.Enabled;
            // Save the left click decoration settings.
            settings.ClickRippleAnimDirection = (uint)_leftClickOptions.AnimationDirection;
            settings.ClickRippleSpeed = _leftClickOptions.AnimationSpeed;
            settings.ClickRippleEasingType = (uint)_leftClickOptions.InterpolationType;
            settings.ClickRippleEnabled = _leftClickOptions.Enabled;
            settings.ClickRippleFadeColor = _leftClickOptions.CanFadeColor;
            settings.ClickRippleProfile= (uint)_leftClickOptions.CurrentRippleProfile;
            settings.Save();
        }

        #region Properties
        internal HighlighterInfo HighlighterOptions => _highlighterSettings;
        internal RippleProfileOptions LeftClickOptions => _leftClickOptions;
        internal RippleProfileOptions RightClickOptions => _rightClickOptions;

        #endregion
    }
}

