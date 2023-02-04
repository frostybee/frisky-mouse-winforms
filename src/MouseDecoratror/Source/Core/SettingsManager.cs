using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseDecoratror.Core
{
    internal class SettingsManager
    {
        private readonly HighlighterSettings _highlighterSettings = new HighlighterSettings();
        internal SettingsManager() { }

        internal void LoadAppSettings()
        {
            // Load first the highlighter settings.
            _highlighterSettings.CenterX = Properties.Settings.Default.HighlighterCenterX;
            _highlighterSettings.CenterY = Properties.Settings.Default.HighlighterCenterY;
            _highlighterSettings.Radius = Properties.Settings.Default.HighlighterRadius;
            _highlighterSettings.Opacity = Properties.Settings.Default.HighlighterOpacity;
            _highlighterSettings.FillColor = Properties.Settings.Default.HighlighterFillColor;
            _highlighterSettings.OutlineColor = Properties.Settings.Default.HighlighterOutlineColor;
            _highlighterSettings.IsFilled = Properties.Settings.Default.HighlighterIsFilled;
            _highlighterSettings.OutlineThickness = Properties.Settings.Default.HighlighterOutlineThickness;
            _highlighterSettings.OutlineStyle = Properties.Settings.Default.HighlighterOutlineStyle;
            _highlighterSettings.IsEnabled = Properties.Settings.Default.IsHighlighterEnabled;
        }

        internal void SaveHighlighterSettings()
        {
            Properties.Settings.Default.HighlighterCenterX = _highlighterSettings.CenterX;
            Properties.Settings.Default.HighlighterCenterY = _highlighterSettings.CenterY;
            Properties.Settings.Default.HighlighterRadius = _highlighterSettings.Radius;
            Properties.Settings.Default.HighlighterOpacity = _highlighterSettings.Opacity;
            Properties.Settings.Default.HighlighterFillColor = _highlighterSettings.FillColor;
            Properties.Settings.Default.HighlighterOutlineColor = _highlighterSettings.OutlineColor;
            Properties.Settings.Default.HighlighterIsFilled = _highlighterSettings.IsFilled;
            Properties.Settings.Default.HighlighterOutlineThickness = _highlighterSettings.OutlineThickness;
            Properties.Settings.Default.HighlighterOutlineStyle = _highlighterSettings.OutlineStyle;
            Properties.Settings.Default.IsHighlighterEnabled = _highlighterSettings.IsEnabled;
            //throw new NotImplementedException();
            Properties.Settings.Default.Save();
        }

        #region Properties
        internal HighlighterSettings HighlighterSettings
        {
            get
            {
                return _highlighterSettings;
            }
        }
        #endregion
    }
}
