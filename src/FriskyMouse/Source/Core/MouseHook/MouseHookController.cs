using Frostybee.GlobalHooks;
using Frostybee.GlobalHooks.NativeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frostybee.MouseDecorator.Core
{
    internal class MouseHookController : GlobalHook
    {
        private int _systemDoubleClickTime;
        private MouseHighlighter _mouseHighlighter;
        private ClickDecorator _clickDecorator;
        private static object _syncRoot = new Object();
        private IntPtr _mouseHookHandle = IntPtr.Zero;        
        public MouseHookController(MouseHighlighter mouseHighlighter, ClickDecorator clickDecorator)
        {
            _mouseHighlighter = mouseHighlighter;
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
                    case MouseButtonTypes.MouseMove:
                        //Debug.WriteLine("Mouse moved..." + hookStruct.pt.X);
                        _mouseHighlighter?.MoveSpotlight(hookStruct.pt);                        
                        break;
                    case MouseButtonTypes.RightButtonDown:
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

