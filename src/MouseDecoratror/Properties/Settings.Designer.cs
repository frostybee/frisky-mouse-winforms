﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MouseDecoratror.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int HighlighterCenterX {
            get {
                return ((int)(this["HighlighterCenterX"]));
            }
            set {
                this["HighlighterCenterX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int HighlighterCenterY {
            get {
                return ((int)(this["HighlighterCenterY"]));
            }
            set {
                this["HighlighterCenterY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int HighlighterRadius {
            get {
                return ((int)(this["HighlighterRadius"]));
            }
            set {
                this["HighlighterRadius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int HighlighterOpacity {
            get {
                return ((int)(this["HighlighterOpacity"]));
            }
            set {
                this["HighlighterOpacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 128")]
        public global::System.Drawing.Color HighlighterFillColor {
            get {
                return ((global::System.Drawing.Color)(this["HighlighterFillColor"]));
            }
            set {
                this["HighlighterFillColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HighlighterIsFilled {
            get {
                return ((bool)(this["HighlighterIsFilled"]));
            }
            set {
                this["HighlighterIsFilled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int HighlighterOutlineThickness {
            get {
                return ((int)(this["HighlighterOutlineThickness"]));
            }
            set {
                this["HighlighterOutlineThickness"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Solid")]
        public global::System.Drawing.Drawing2D.DashStyle HighlighterOutlineStyle {
            get {
                return ((global::System.Drawing.Drawing2D.DashStyle)(this["HighlighterOutlineStyle"]));
            }
            set {
                this["HighlighterOutlineStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color HighlighterOutlineColor {
            get {
                return ((global::System.Drawing.Color)(this["HighlighterOutlineColor"]));
            }
            set {
                this["HighlighterOutlineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsHighlighterEnabled {
            get {
                return ((bool)(this["IsHighlighterEnabled"]));
            }
            set {
                this["IsHighlighterEnabled"] = value;
            }
        }
    }
}
