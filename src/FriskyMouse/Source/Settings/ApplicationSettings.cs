using FriskyMouse.Drawing.Ripples;

namespace FriskyMouse.Core
{
    public class ApplicationSettings
    {
        #region Properties        
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public HighlighterOptions HighlighterOptions { get; set; } = new HighlighterOptions();
        public RippleProfileOptions LeftClickOptions { get; set; } = new RippleProfileOptions();
        public RippleProfileOptions RightClickOptions { get; set; } = new RippleProfileOptions();   

        #endregion
    }
}

