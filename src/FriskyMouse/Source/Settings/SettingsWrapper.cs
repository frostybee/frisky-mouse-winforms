using FriskyMouse.Drawing.Ripples;

namespace FriskyMouse.Settings
{
    internal class SettingsWrapper
    {
        #region Properties                
        public ApplicationSettings ApplicationSettings { get; set; } = new ApplicationSettings();

        public HighlighterOptions HighlighterOptions { get; set; } = new HighlighterOptions();
        public RippleProfileOptions LeftClickOptions { get; set; } = new RippleProfileOptions();
        public RippleProfileOptions RightClickOptions { get; set; } = new RippleProfileOptions();

        #endregion

    }
}
