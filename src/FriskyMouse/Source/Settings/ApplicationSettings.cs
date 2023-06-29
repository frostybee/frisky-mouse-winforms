#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

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

