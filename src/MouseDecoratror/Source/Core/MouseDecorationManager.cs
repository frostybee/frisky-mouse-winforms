using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using Bee.MouseDecorator.UI;
using MouseDecoratror.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bee.MouseDecorator.Core
{
    //TODO: Dispose everything here.
    internal class MouseDecorationManager : IDisposable
    {
        // The user settings manager. 
        private readonly SettingsManager _settingsManager = new SettingsManager();
        private object syncLock = new object();
        private readonly MouseHighlighter _mouseHighlighter = new MouseHighlighter();
        private readonly ClickDecorator _clickDecorator = new ClickDecorator();
        private MouseHookController globalHookManager;
        private bool isHookRunning;
        private bool disposedValue = false;
        // The single instance of this class. 
        private static readonly Lazy<MouseDecorationManager> _instance = new Lazy<MouseDecorationManager>(() => new MouseDecorationManager());
        private MouseDecorationManager()
        {
            isHookRunning = false;
            globalHookManager = new MouseHookController(_mouseHighlighter, _clickDecorator);
            //LoadDecorationSettings();
        }

        #region Methods
        private void ConfigMouseHighlighter()
        {
            // Configure cursor _highlighterSettings.            
            _mouseHighlighter.SetupHighlighter(_settingsManager.HighlighterSettings);
        }
        private void LoadDecorationSettings()
        {

            // Configure single click decorator.
            BitmapStyleInfo singleClickStyle = new BitmapStyleInfo { Size = 20, Color = Color.Red, PenSize = 3, Opacity = 200, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            _clickDecorator.SetClickStyle(singleClickStyle);

            // Configure double click decorator.
            BitmapStyleInfo doubleClickStyle = new BitmapStyleInfo { Size = 3, Color = Color.Red, Opacity = 236, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            //clickDecorator.SetDoubleClickStyle(doubleClickStyle);
        }
        //int previousClick = 0;


        public void EnableHook()
        {
            //TODO: handle hook return type/errors
            // TODO: check if the _highlighterSettings is enabled in the settings or not. 
            // TODO: check also if the click decorator is enabled.
            lock (syncLock)
            {
                if (!isHookRunning)
                {
                    globalHookManager.InstallHook();
                    isHookRunning = true;
                    _mouseHighlighter.LayeredWindow?.Show();
                    //--
                    //LoadDecorationSettings();                    
                }
            }
        }

        public void DisableHook()
        {
            lock (syncLock)
            {
                if (isHookRunning)
                {
                    //TODO: dispose bitmaps
                    globalHookManager.UninstallHook();
                    isHookRunning = false;
                    // Hide the layered window.
                    _mouseHighlighter.LayeredWindow?.Hide();
                }
            }
        }

        internal void ApplyHighlighterSettings()
        {
            // Save the newly editted settings.
            _settingsManager.SaveHighlighterSettings();

            if (_settingsManager.HighlighterSettings.IsEnabled)
            {
                // TODO: Apply the new highlighter settings by updating the bitmap shown onto the layered window.
                ConfigMouseHighlighter();
            }
        }

        internal void BootstrapApp()
        {
            // First, we need to load the applications settings.
            _settingsManager.LoadAppSettings();
            // TODO: add check ==> Is click decorator enabled as well?
            if (_settingsManager.HighlighterSettings.IsEnabled)
            {
                ConfigMouseHighlighter();
                EnableHook();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _mouseHighlighter?.Dispose();
                    _clickDecorator?.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MouseDecorationManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }


        #endregion

        #region Properties
        /// <summary>
        /// Gets the single instance of this class.
        /// This property is thread safe. 
        /// </summary>
        public static MouseDecorationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public SettingsManager SettingsManager
        {
            get
            {
                return _settingsManager;
            }
        }

        public MouseHighlighter MouseHighlighter { get => _mouseHighlighter; }
        public ClickDecorator ClickDecorator { get => _clickDecorator; }


        #endregion
    }
}
