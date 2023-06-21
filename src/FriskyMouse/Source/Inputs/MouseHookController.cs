using FriskyMouse.NativeApi;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FriskyMouse.Core
{
    internal class MouseHookController : GlobalInputsHook
    {
        private int _systemDoubleClickTime;
        private HighlighterController _highlighter;
        private RippleProfilesAnimator _clickDecorator;
        private RippleProfilesAnimator _rightClickDecorator;
        private static object _syncRoot = new Object();
        private IntPtr _mouseHookHandle = IntPtr.Zero;
        public MouseHookController(HighlighterController highlighter, RippleProfilesAnimator clickDecorator, 
            RippleProfilesAnimator rightClickDecorator)
        {
            _highlighter = highlighter;
            _clickDecorator = clickDecorator;
            _rightClickDecorator = rightClickDecorator;
            _systemDoubleClickTime = SystemInformation.DoubleClickTime;
            _hookType = NativeMethods.WH_MOUSE_LL;
        }

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
                        _clickDecorator.ShowRipplesAt(hookStruct.pt.X, hookStruct.pt.Y);
                        break;
                    case MouseButtonTypes.LeftButtonUp:
                        // Fix the issue when the highlighter is no longer top most.
                        // TODO: lock the involved objects. This is causing an InvalidOperationException.
                        //Task.Delay(200).ContinueWith(t => _highlighter?.BringToFront(hookStruct.pt));
                        break;
                    case MouseButtonTypes.MouseMove:
                        _highlighter?.MoveSpotlight(hookStruct.pt);
                        break;
                    case MouseButtonTypes.RightButtonUp:
                        // Fix the issue when the highlighter is no longer top most.                        
                        Task.Delay(200).ContinueWith(t => _highlighter?.BringToFront(hookStruct.pt));
                        //Task.Delay(200).ContinueWith(t => _rightClickDecorator?.SetTopMost(hookStruct.pt.X, hookStruct.pt.Y));
                        //_rightClickDecorator.SetTopMost(hookStruct.pt.X, hookStruct.pt.Y);
                        _rightClickDecorator.ShowRipplesAt(hookStruct.pt.X, hookStruct.pt.Y);
                        //_settings.BringToFront(hookStruct.pt);
                        /*_leftClickDecorator?.DecorateLeftSingleClick(new RawMouseEvents
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
    }
}

