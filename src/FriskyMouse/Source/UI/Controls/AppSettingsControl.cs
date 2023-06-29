#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.Core;
using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Settings;
using MaterialSkin;

namespace FriskyMouse.UI.Controls
{
    public partial class AppSettingsControl : UserControl
    {
        private readonly ApplicationSettings _settings;
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly DecorationManager _decorationManager;
        public AppSettingsControl()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            _materialSkinManager = MaterialSkinManager.Instance;
            _decorationManager = DecorationManager.Instance;
            _settings = SettingsManager.Settings.ApplicationSettings;
        }

        private void CmbColorScheme_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ColorSchemeType schemeType = cmbColorScheme.GetSelectedEnumValue<ColorSchemeType>();
            _settings.ColorScheme = schemeType;
            LoadColorScheme(schemeType);
        }

        private void LoadColorScheme(ColorSchemeType colorScheme)
        {
            ColorScheme selectedScheme = ColorSchemeFactory.GetColorScheme(colorScheme);
            _materialSkinManager.ColorScheme = selectedScheme;
            _decorationManager.MainForm?.Invalidate();
            Invalidate();
        }

        private void SwitchChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            _materialSkinManager.Theme = switchChangeTheme.Checked ?
                MaterialSkinManager.Themes.DARK :
                MaterialSkinManager.Themes.LIGHT;
        }

        internal void UpdateControlsFromSettings()
        {
            // Populate the combo box with the list of color scheme descriptions.            
            cmbColorScheme.PopulateFromEnum<ColorSchemeType>();
            cmbColorScheme.SelectedIndex = cmbColorScheme.GetItemIndexByEumValue(_settings.ColorScheme);
            cmbColorScheme.SelectedIndexChanged += CmbColorScheme_SelectedIndexChanged;
            LoadColorScheme(_settings.ColorScheme);
        }
    }
}
