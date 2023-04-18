using FriskyMouse.GlobalHooks;
using FriskyMouse.MouseDecorator.UI;
using FriskyMouse.MouseDecorator.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FriskyMouse.MouseDecorator.Core
{
    //TODO: Dispose everything here.
    internal class DecorationController : IDisposable
    {
        private bool _disposed = false;
        // The user settings manager. 
        private readonly SettingsManager _settingsManager = new SettingsManager();
        private readonly object _syncLock = new object();
        private readonly HighlighterController _mouseHighlighter = new HighlighterController();
        private readonly ClickDecorator _clickDecorator = new ClickDecorator();
        private MouseHookController _mouseHookController;        
        // The single instance of this class. 
        private static readonly Lazy<DecorationController> _instance = new Lazy<DecorationController>(() => new DecorationController());
        private DecorationController()
        {
            _mouseHookController = new MouseHookController(_mouseHighlighter, _clickDecorator);
            //LoadDecorationSettings();
        }

        #region Methods
        private void ConfigMouseHighlighter()
        {
            // Configure cursor _highlighterModel.            
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


        public void EnableHighlighter()
        {
            //TODO: handle hook return type/errors
            // TODO: check if the _highlighterModel is enabled in the settings or not. 
            // TODO: check also if the click decorator is enabled.
            lock (_syncLock)
            {
                _mouseHookController.Install();
                _mouseHighlighter.LayeredWindow?.Show();
                //--
                //LoadDecorationSettings();                    
            }
        }
                
        public void DisableHook()
        {
            lock (_syncLock)
            {
                //TODO: dispose bitmaps
                _mouseHookController.Uninstall();
                // Hide the layered window.
                _mouseHighlighter.LayeredWindow?.Hide();
            }
        }

        internal void ApplyHighlighterSettings()
        {
            // Save the newly edited settings.
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
                EnableHighlighter();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _mouseHighlighter?.Dispose();
                    _clickDecorator?.Dispose();
                    Debug.WriteLine("Disposed the manager....");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposed = true;
            }
        }

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
        public static DecorationController Instance => _instance.Value;
        public SettingsManager SettingsManager => _settingsManager;
        public HighlighterController MouseHighlighter => _mouseHighlighter;
        public ClickDecorator ClickDecorator => _clickDecorator;

        #endregion
    }
}
