using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostybee.MouseDecorator.Core
{
    internal class SettingsManager
    {
        private readonly HighlighterSettings _highlighterSettings = new HighlighterSettings();
        internal SettingsManager() { }

        internal void LoadAppSettings()
        {
            var settings = Properties.Settings.Default;
            // Load first the highlighter settings.
            _highlighterSettings.CenterX = settings.HighlighterCenterX;
            _highlighterSettings.CenterY = settings.HighlighterCenterY;
            _highlighterSettings.Radius = settings.HighlighterRadius;
            _highlighterSettings.Opacity = settings.HighlighterOpacity;
            _highlighterSettings.FillColor = settings.HighlighterFillColor;
            _highlighterSettings.OutlineColor = settings.HighlighterOutlineColor;
            _highlighterSettings.IsFilled = settings.HighlighterIsFilled;
            _highlighterSettings.OutlineThickness = settings.HighlighterOutlineThickness;
            _highlighterSettings.OutlineStyle = settings.HighlighterOutlineStyle;
            _highlighterSettings.IsEnabled = settings.IsHighlighterEnabled;
        }

        internal void SaveHighlighterSettings()
        {
            var settings = Properties.Settings.Default;
            settings.HighlighterCenterX = _highlighterSettings.CenterX;
            settings.HighlighterCenterY = _highlighterSettings.CenterY;
            settings.HighlighterRadius = _highlighterSettings.Radius;
            settings.HighlighterOpacity = _highlighterSettings.Opacity;
            settings.HighlighterFillColor = _highlighterSettings.FillColor;
            settings.HighlighterOutlineColor = _highlighterSettings.OutlineColor;
            settings.HighlighterIsFilled = _highlighterSettings.IsFilled;
            settings.HighlighterOutlineThickness = _highlighterSettings.OutlineThickness;
            settings.HighlighterOutlineStyle = _highlighterSettings.OutlineStyle;
            settings.IsHighlighterEnabled = _highlighterSettings.IsEnabled;
            //throw new NotImplementedException();
            settings.Save();
        }

        #region Properties
        internal HighlighterSettings HighlighterSettings => _highlighterSettings;        
        #endregion
    }
}
