using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bee.MouseDecorator.Core
{
    //TODO: Dispose everything here.
    internal class DecorationController : IDisposable
    {
        private static volatile DecorationController instance = null;
        private static object syncLock = new Object();
        private readonly CursorDecorator cursorDecorator;
        private readonly ClickDecorator clickDecorator;
        private GlobalHookManager globalHookManager;
        private RawMouseEventArgs previousMouseUpEvent;
        private RawMouseEventArgs previousMouseDownEvent;
        private bool isHookRunning;
        private bool disposedValue = false;
        private int systemDoubleClickTime;

        private DecorationController()
        {
            isHookRunning = false;
            systemDoubleClickTime = SystemInformation.DoubleClickTime;
            globalHookManager = GlobalHookManager.Instance;            
            previousMouseUpEvent = new RawMouseEventArgs();
            previousMouseDownEvent = new RawMouseEventArgs();            
            clickDecorator = new ClickDecorator();
            cursorDecorator = new CursorDecorator();
            LoadDecorationSettings();
        }

        #region Methods
        private void LoadDecorationSettings()
        {
            // Configure cursor highlighter.
            BitmapStyleInfo cursorHighlightStyle = new BitmapStyleInfo { 
                Size = 40, Color = Color.Aqua, PenSize = 5, Opacity = 200, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = true 
            };
            cursorDecorator.SetupCursorDecorator(cursorHighlightStyle);
            // Configure single click decorator.
            BitmapStyleInfo singleClickStyle = new BitmapStyleInfo { Size = 20, Color = Color.Red, PenSize = 3, Opacity = 200, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            clickDecorator.SetClickStyle(singleClickStyle);

            // Configure double click decorator.
            BitmapStyleInfo doubleClickStyle = new BitmapStyleInfo { Size = 3, Color = Color.Red, Opacity = 236, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            //clickDecorator.SetDoubleClickStyle(doubleClickStyle);
        }
        //int previousClick = 0;
        private void GlobalHookManager_MouseAction(object sender, RawMouseEventArgs e)
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
                            clickDecorator.DecorateLeftSingleClick(e);
                            Console.WriteLine("Decorate single click...");
                        }
                    }
                    previousMouseUpEvent = e;
                    break;
                case MouseButtonTypes.MouseMove:
                    cursorDecorator.DecorateMouseMove(e.Point);
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
        private bool IsMouseDragged(RawMouseEventArgs e)
        {
            //return (e.TimeStamp - previousMouseEvent.TimeStamp <= systemDoubleClickTime)
            return e.Point != previousMouseDownEvent.Point;
        }
        private bool IsDoubleClick(RawMouseEventArgs e)
        {
            return (e.TimeStamp - previousMouseUpEvent.TimeStamp <= systemDoubleClickTime)
                && e.Point == previousMouseUpEvent.Point
                && e.MessageType == previousMouseUpEvent.MessageType;
        }

        public void EnableHook()
        {
            //TODO: handle hook return type/errors
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
                    cursorDecorator?.Dispose();
                    clickDecorator?.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~DecorationController()
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
        /// <see cref="https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650316(v=pandp.10)?redirectedfrom=MSDN"/>
        /// </summary>
        public static DecorationController Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new DecorationController();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion
    }
}
