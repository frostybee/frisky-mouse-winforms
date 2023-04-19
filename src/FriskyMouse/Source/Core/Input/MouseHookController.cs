using FriskyMouse.NativeApi;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FriskyMouse.Core
{
    internal class MouseHookController : GlobalHook
    {
        private int _systemDoubleClickTime;
        private HighlighterController _highlighter;
        private ClickDecorator _clickDecorator;
        private static object _syncRoot = new Object();
        private IntPtr _mouseHookHandle = IntPtr.Zero;        
        public MouseHookController(HighlighterController mouseHighlighter, ClickDecorator clickDecorator)
        {
            _highlighter = mouseHighlighter;
            _clickDecorator = clickDecorator;
            _systemDoubleClickTime = SystemInformation.DoubleClickTime;
            _hookType = NativeMethods.WH_MOUSE_LL;
        }

        #region Private Methods
        protected override IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
        {
            MouseButtonTypes messageType = (MouseButtonTypes)wParam;
            //Debug.WriteLine("wParam..." + wParam);
            if (nCode < 0)
            {
                return NativeMethods.CallNextHookEx(_mouseHookHandle, nCode, wParam, lParam);
            }
            if (nCode >= 0)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                switch (messageType)
                {
                    case MouseButtonTypes.LeftButtonDown:
                    case MouseButtonTypes.LeftButtonUp:
                        // Fix the issue when the highlighter is no longer top most.
                        _highlighter.BringToFront(hookStruct.pt);
                        break;
                    case MouseButtonTypes.MouseMove:
                        //Debug.WriteLine("Mouse moved..." + hookStruct.pt.X);
                        _highlighter?.MoveSpotlight(hookStruct.pt);                        
                        break;
                    case MouseButtonTypes.RightButtonUp:
                        // Fix the issue when the highlighter is no longer top most.
                        _highlighter.BringToFront(hookStruct.pt);
                        /*_clickDecorator?.DecorateLeftSingleClick(new RawMouseEvents
                        {
                            MessageType = (MouseButtonTypes)wParam,
                            Point = hookStruct.pt,
                            MouseData = hookStruct.mouseData,
                            TimeStamp = hookStruct.time
                        });*/
                        //EventHandler<HookMouseEventArgs> handler = MouseAction;
                        /*OnMouseAction?.Invoke(this,
                            new RawMouseEvents
                            {
                                MessageType = (MouseButtonTypes)wParam,
                                Point = hookStruct.pt,
                                MouseData = hookStruct.mouseData,
                                TimeStamp = hookStruct.time
                            });*/
                        //Debug.WriteLine("Mouse moved..." + hookStruct.pt.X);
                        break;
                    case MouseButtonTypes.LeftButtonDoubleClick:
                        Debug.WriteLine("Mouse moved..." + hookStruct.pt.X);
                        break;
                    default:
                        break;
                }

            }
            return NativeMethods.CallNextHookEx(_mouseHookHandle, nCode, wParam, lParam);
        }
        #endregion

        #region Public Methods
       
        #endregion
        
    }
}

