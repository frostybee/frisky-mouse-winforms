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
        private readonly HighlighterController _highlighter;
        private readonly RippleProfilesAnimator _leftClickDecorator;
        private readonly RippleProfilesAnimator _rightClickDecorator;
        private readonly MouseHookController _mouseHookController;
        private readonly object _syncLock = new object();
        private bool _disposed = false;

        private DecorationController()
        {
            _settingsManager = new SettingsManager();
            _leftClickDecorator = new RippleProfilesAnimator(_settingsManager);
            _rightClickDecorator = new RippleProfilesAnimator(_settingsManager);
            _highlighter = new HighlighterController(_settingsManager);
            _mouseHookController = new MouseHookController(_highlighter, _leftClickDecorator, _rightClickDecorator);
        }

        #region Methods
        
        internal void EnableHighlighter()
        {            
            _highlighter.InitHighlighter(_settingsManager.HighlighterOptions);        
        }         
        internal void DisableHighlighter()
        {
            // HideSpotlight the layered window.
            _highlighter.HideSpotlight();
            if (_settingsManager.HighlighterOptions.Enabled)
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
                _highlighter?.HideSpotlight();
            }
        }

        internal void ApplyHighlighterSettings()
        {
            // Save the newly edited settings.
            _settingsManager.SaveDecorationSettings();

            if (_settingsManager.HighlighterOptions.Enabled)
            {                
                EnableHighlighter();
            }
        }

        internal void BootstrapApp()
        {            
            _settingsManager.LoadAppSettings();
            // TODO: add check ==> Is click decorator enabled as well?
            //EnableHook();
            if (_mouseHookController.Started)
            {
                if (_settingsManager.HighlighterOptions.Enabled)
                {
                    // Set the initial coordinates of the spotlight upon starting the application.
                    _highlighter.SetInitialPosition();
                    EnableHighlighter();
                }
            }
            else 
            {
                // TODO: Failed to install the mouse hook... Raise an error.
            }                    
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {                    
                    _highlighter?.Dispose();                    
                    _leftClickDecorator?.Dispose();
                    _rightClickDecorator?.Dispose();    
                }
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
        public HighlighterController MouseHighlighter => _highlighter;
        public RippleProfilesAnimator ClickDecorator => _leftClickDecorator;

        public MainForm MainForm { get; internal set; }

        #endregion
    }
}