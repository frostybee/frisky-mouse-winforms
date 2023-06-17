using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;
using System.ComponentModel;

namespace FriskyMouse.Core
{
    public class ApplicationSettings
    {
        #region Properties        
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public HighlighterInfo HighlighterOptions { get; set; } = new HighlighterInfo();
        public RippleProfileOptions LeftClickOptions { get; set; } = new RippleProfileOptions();
        public RippleProfileOptions RightClickOptions { get; set; } = new RippleProfileOptions();   

        #endregion
    }
}

