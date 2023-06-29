#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.NativeApi;
using MaterialSkin.Controls;
using FriskyMouse.Extensions;

namespace FriskyMouse.Helpers
{
    public static class AppHelpers
    {

        public static readonly Version OSVersion = Environment.OSVersion.Version;

        public static T[] GetEnums<T>()
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        public static int GetEnumLength<T>()
        {
            return Enum.GetValues(typeof(T)).Length;
        }

        public static T GetEnumFromIndex<T>(int i)
        {
            return GetEnums<T>()[i];
        }

        public static string GetApplicationVersion(bool includeRevision = false)
        {
            Version version = typeof(AppHelpers).Assembly.GetName().Version; 
            string result = $"{version.Major}.{version.Minor}.{version.Build}";
            if (includeRevision)
            {
                result = $"{result}.{version.Revision}";
            }
            return result;
        }

        /// <summary>
        /// If version1 newer than version2 = 1
        /// If version1 equal to version2 = 0
        /// If version1 older than version2 = -1
        /// </summary>
        public static int CompareVersion(string version1, string version2)
        {
            return NormalizeVersion(version1).CompareTo(NormalizeVersion(version2));
        }

        /// <summary>
        /// If version1 newer than version2 = 1
        /// If version1 equal to version2 = 0
        /// If version1 older than version2 = -1
        /// </summary>
        public static int CompareVersion(Version version1, Version version2)
        {
            return version1.Normalize().CompareTo(version2.Normalize());
        }

        /// <summary>
        /// If version newer than ApplicationVersion = 1
        /// If version equal to ApplicationVersion = 0
        /// If version older than ApplicationVersion = -1
        /// </summary>
        public static int CompareApplicationVersion(string version, bool includeRevision = false)
        {
            return CompareVersion(version, GetApplicationVersion(includeRevision));
        }

        public static Version NormalizeVersion(string version)
        {
            return Version.Parse(version).Normalize();
        }
        internal static POINT GetCursorPosition()
        {
            if (NativeMethods.GetCursorPos(out POINT point))
            {
                return point;
            }

            return POINT.Empty;
        }

        internal static Color GetUserSelectedColor(Color initialColor)
        {
            ColorDialog colorPicker = new()
            {
                // Keeps the user from selecting a custom color.
                AllowFullOpen = true,
                FullOpen = true,
                // Allows the user to get help. (The default is false.)
                ShowHelp = true,
                // Sets the initial color select to the current text color.
                Color = initialColor                              
            };
            
            // Update the text box color if the user clicks OK 
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                return colorPicker.Color;                
            }
            colorPicker?.Dispose(); 
            return initialColor;
        }

        internal static void UpdateSwitchText(MaterialSwitch materialSwitch)
        {
            materialSwitch.Text = (materialSwitch.Checked) ? "On" : "Off";
        }
    }
}