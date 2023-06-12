using FriskyMouse.HelpersLib.Drawing;

namespace FriskyMouse.Core
{
    internal class SettingsManager
    {
        private readonly HighlighterInfo _highlighterSettings = new HighlighterInfo();
        private readonly RippleProfileInfo _clickProfileOptions = new RippleProfileInfo();
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
        }
        
        internal void SaveHighlighterSettings()
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
            //throw new NotImplementedException();
            settings.Save();
        }

        #region Properties
        internal HighlighterInfo HighlighterSettings => _highlighterSettings;        
        internal RippleProfileInfo ClickProfileOptions=> _clickProfileOptions;        
        #endregion
    }
}
