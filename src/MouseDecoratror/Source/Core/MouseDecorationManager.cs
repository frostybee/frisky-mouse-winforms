using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using MouseDecoratror.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bee.MouseDecorator.Core
{
    //TODO: Dispose everything here.
    internal class MouseDecorationManager : IDisposable
    {
        private static readonly Lazy<MouseDecorationManager> _instance = new Lazy<MouseDecorationManager>(() => new MouseDecorationManager());
        private readonly SettingsManager _settingsManager = new SettingsManager();
        private object syncLock = new object();
        private MouseHighlighter mouseHighlighter;
        private ClickDecorator clickDecorator;
        private GlobalHookManager globalHookManager;
        private RawMouseEvents previousMouseUpEvent;
        private RawMouseEvents previousMouseDownEvent;
        private bool isHookRunning;
        private bool disposedValue = false;
        private int systemDoubleClickTime;

        private MouseDecorationManager()
        {
            isHookRunning = false;
            systemDoubleClickTime = SystemInformation.DoubleClickTime;
            globalHookManager = GlobalHookManager.Instance;
            previousMouseUpEvent = new RawMouseEvents();
            previousMouseDownEvent = new RawMouseEvents();
            mouseHighlighter = new MouseHighlighter();
            //LoadDecorationSettings();
        }

        #region Methods
        private void ConfigMouseHighlighter()
        {
            if (mouseHighlighter == null)
            {
                mouseHighlighter = new MouseHighlighter();
            }            
            // Configure cursor _highlighterSettings.            
            mouseHighlighter.SetupHighlighter(_settingsManager.HighlighterSettings);
        }
        private void LoadDecorationSettings()
        {

            // Configure single click decorator.
            BitmapStyleInfo singleClickStyle = new BitmapStyleInfo { Size = 20, Color = Color.Red, PenSize = 3, Opacity = 200, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            clickDecorator.SetClickStyle(singleClickStyle);

            // Configure double click decorator.
            BitmapStyleInfo doubleClickStyle = new BitmapStyleInfo { Size = 3, Color = Color.Red, Opacity = 236, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            //clickDecorator.SetDoubleClickStyle(doubleClickStyle);
        }
        //int previousClick = 0;
        private void GlobalHookManager_MouseAction(object sender, RawMouseEvents e)
        {
            switch (e.MessageType)
            {
                case MouseButtonTypes.LeftButtonDown:
                    // Keep track of the mouse event. This will serve as a flag to detect if the mosue has been moved. 
                    previousMouseDownEvent = e;
                    //hasMouseMoved = false;
                    // Decorate a single click only when the mouse hasn't dragged.
                    //if (!IsMouseDragged(e) && !IsDoubleClick(e))
                    /*if (!IsDoubleClick(e))
                    {
                        clickDecorator.DecorateLeftSingleClick(e);
                    }*/
                    //previousMouseEvent = e;
                    break;

                case MouseButtonTypes.LeftButtonUp:

                    //Console.WriteLine("Left button down" + e.Point.x + " " + e.Point.y);
                    int now = System.Environment.TickCount;
                    // Is it a double click?
                    if (IsDoubleClick(e))
                    //if (e.TimeStamp - previousMouseEvent.TimeStamp <= doubleClickTime)
                    {
                        //clickDecorator.DecorateDoubleClick(e);
                        //return;
                        Console.WriteLine("Decorate double click...");
                    }
                    else
                    {
                        // Is the current click not part of a double click sequence.
                        // Meaning? the current click's time is greater than the system double click time.
                        if (!IsDoubleClick(e) && !IsMouseDragged(e))
                        {
                            //clickDecorator.DecorateLeftSingleClick(e);
                            Console.WriteLine("Decorate single click...");
                        }
                    }
                    previousMouseUpEvent = e;
                    break;
                case MouseButtonTypes.MouseMove:
                    mouseHighlighter.DecorateMouseMove(e.Point);
                    break;

                case MouseButtonTypes.LeftButtonDoubleClick:
                    break;
                case MouseButtonTypes.MouseWheel:
                    break;
                case MouseButtonTypes.RightButtonDown:
                    //clickDecorator.DecorateLeftButtonDown(e);
                    break;
                case MouseButtonTypes.RightButtonUp:
                    break;
                default:
                    break;
            }
        }
        private bool IsMouseDragged(RawMouseEvents e)
        {
            //return (e.TimeStamp - previousMouseEvent.TimeStamp <= systemDoubleClickTime)
            return e.Point != previousMouseDownEvent.Point;
        }
        private bool IsDoubleClick(RawMouseEvents e)
        {
            return (e.TimeStamp - previousMouseUpEvent.TimeStamp <= systemDoubleClickTime)
                && e.Point == previousMouseUpEvent.Point
                && e.MessageType == previousMouseUpEvent.MessageType;
        }

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
                    //--
                    //LoadDecorationSettings();
                    globalHookManager.OnMouseAction += GlobalHookManager_MouseAction;
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
                    globalHookManager.OnMouseAction -= GlobalHookManager_MouseAction;
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    mouseHighlighter?.Dispose();
                    clickDecorator?.Dispose();
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

        internal void ApplyHighlighterSettings()
        {
            // Save the newly editted settings.
            _settingsManager.SaveHighlighterSettings();

            // TODO: Apply the new highlighter settings by updating the bitmap shown onto the layered window.
            ConfigMouseHighlighter();

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
        #endregion
    }
}
