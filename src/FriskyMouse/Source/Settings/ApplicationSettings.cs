using MaterialSkin;

namespace FriskyMouse.Settings
{
    public class ApplicationSettings
    {
        #region Properties        
        public string ApplicationName { get; set; } = "FriskyMouse";
        public string Version { get; set; } = string.Empty;
        public ColorSchemeType ColorScheme { get; set; } = ColorSchemeType.Blue;

        #endregion
    }
}

