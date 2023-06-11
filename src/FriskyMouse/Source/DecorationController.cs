using FriskyMouse.UI;
using FrostyBee.FriskyRipples;
using System;
using System.Diagnostics;
using System.Threading;

namespace FriskyMouse.Core
{
    //TODO: Dispose everything here.
    internal class DecorationController : IDisposable
    {
        // The single instance of this class. 
        private static readonly Lazy<DecorationController> _instance =
            new Lazy<DecorationController>(() => new DecorationController());        
        private readonly SettingsManager _settingsManager;        
        private readonly HighlighterController _mouseHighlighter;
        private readonly RippleProfilesManager _clickDecorator;
        private readonly MouseHookController _mouseHookController;
        private readonly object _syncLock = new object();
        private bool _disposed = false;

        private DecorationController()
        {
            _settingsManager = new SettingsManager();
            _clickDecorator = new RippleProfilesManager(_settingsManager);
            _mouseHighlighter = new HighlighterController(_settingsManager);
            _mouseHookController = new MouseHookController(_mouseHighlighter, _clickDecorator);
            //LoadDecorationSettings();                        
        }

        #region Methods
        private void ConfigMouseHighlighter()
        {
            // Configure cursor _highlighter.            
            _mouseHighlighter.SetupHighlighter(_settingsManager.HighlighterSettings);
        }
        //int previousClick = 0;

        internal void EnableHighlighter()
        {
            //TODO: handle hook return type/errors
            // TODO: check if the _highlighter is enabled in the settings or not. 
            // TODO: check also if the click decorator is enabled.
            _mouseHighlighter.SetupHighlighter(_settingsManager.HighlighterSettings);
            //--
            //LoadDecorationSettings();                                
        }
        internal void DisableHighlighter()
        {
            // HideSpotlight the layered window.
            _mouseHighlighter.HideSpotlight();
            if (_settingsManager.HighlighterSettings.Enabled)
            {

            }
        }
        public void EnableHook()
        {
            lock (_syncLock)
            {
                _mouseHookController?.Install();
            }
        }
        public void DisableHook()
        {
            lock (_syncLock)
            {
                //TODO: dispose bitmaps
                _mouseHookController?.Uninstall();
                // HideSpotlight the layered window.
                _mouseHighlighter?.HideSpotlight();
            }
        }

        internal void ApplyHighlighterSettings()
        {
            // Save the newly edited settings.
            _settingsManager.SaveHighlighterSettings();

            if (_settingsManager.HighlighterSettings.Enabled)
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
            if (_settingsManager.HighlighterSettings.Enabled)
            {
                ConfigMouseHighlighter();
                EnableHighlighter();                
            }
            EnableHook();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _mouseHighlighter?.Dispose();
                    //TODO: implement Dispose in the ripple manager.
                    //_clickDecorator?.Dispose();
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
        /// Gets the single instance of the decoration engine.
        /// </summary>
        public static DecorationController Instance => _instance.Value;
        public SettingsManager SettingsManager => _settingsManager;
        public HighlighterController MouseHighlighter => _mouseHighlighter;
        public RippleProfilesManager ClickDecorator => _clickDecorator;

        public MainForm MainForm { get; internal set; }

        #endregion
    }
}