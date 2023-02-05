using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee.MouseDecorator.Core
{
    internal class MouseHookController
    {
        private int systemDoubleClickTime;
        private MouseHighlighter _mouseHighlighter;
        private ClickDecorator _clickDecorator;
        private static object syncRoot = new Object();
        private IntPtr _mouseHookHandle = IntPtr.Zero;
        private NativeMethods.MouseHookProc _mouseHookDelegate = null;        

        public MouseHookController(MouseHighlighter mouseHighlighter, ClickDecorator clickDecorator)
        {
            _mouseHighlighter = mouseHighlighter;
            _clickDecorator = clickDecorator;
            systemDoubleClickTime = SystemInformation.DoubleClickTime;
        }

        #region Private Methods
        private IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
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
                        _mouseHighlighter?.DecorateMouseMove(hookStruct.pt);                        
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
        public void InstallHook()
        {
            if (_mouseHookHandle == IntPtr.Zero)
            {
                _mouseHookDelegate = MouseHookCallback;
                _mouseHookHandle = NativeMethods.SetWindowsHookEx(
                    NativeMethods.WH_MOUSE_LL,
                    _mouseHookDelegate,
                    NativeMethods.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName),
                    0);
                if (_mouseHookHandle == IntPtr.Zero)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }
        public void UninstallHook()
        {
            // If it's set, uninstall the mouse hook.
            if (_mouseHookHandle != IntPtr.Zero)
            {
                bool retCode = NativeMethods.UnhookWindowsHookEx(_mouseHookHandle);
                _mouseHookHandle = IntPtr.Zero;
                _mouseHookDelegate = null;
                if (!retCode)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }            
        }
        #endregion
        
    }
}

