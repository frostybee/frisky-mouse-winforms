using Bee.GlobalHooks.NativeApi;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Bee.GlobalHooks
{
    public class GlobalHookManager
    {
        private static volatile GlobalHookManager instance = null;
        private static object syncRoot = new Object();
        private IntPtr hMouseHook = IntPtr.Zero;
        private NativeMethods.LowLevelMouseProc hookCallback = null;
        public event EventHandler<RawMouseEvents> OnMouseAction;
        private GlobalHookManager() { }

        #region Private Methods
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            MouseButtonTypes messageType = (MouseButtonTypes)wParam;

            if (nCode < 0)
            {
                return NativeMethods.CallNextHookEx(hMouseHook, nCode, wParam, lParam);
            }
            if (nCode >= 0)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                switch (messageType)
                {
                    case MouseButtonTypes.LeftButtonDown:
                    case MouseButtonTypes.LeftButtonUp:
                    case MouseButtonTypes.MouseMove:
                    case MouseButtonTypes.RightButtonDown:
                        //EventHandler<HookMouseEventArgs> handler = MouseAction;
                        OnMouseAction?.Invoke(this,
                            new RawMouseEvents
                            {
                                MessageType = (MouseButtonTypes)wParam,
                                Point = hookStruct.pt,
                                MouseData = hookStruct.mouseData,
                                TimeStamp = hookStruct.time
                            });
                        break;
                    default:
                        break;
                }

            }
            return NativeMethods.CallNextHookEx(hMouseHook, nCode, wParam, lParam);
        }
        #endregion

        #region Public Methods
        public IntPtr InstallHook()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                hookCallback = new NativeMethods.LowLevelMouseProc(HookCallback);
                return NativeMethods.SetWindowsHookEx(
                    NativeMethods.WH_MOUSE_LL, hookCallback,
                    NativeMethods.GetModuleHandle(curModule.ModuleName),
                    0);
            }
        }
        public IntPtr UninstallHook()
        {
            // If it's set, uninstall the mouse hook.
            if (hMouseHook != IntPtr.Zero)
            {
                Int32 retCode = NativeMethods.UnhookWindowsHookEx(hMouseHook);
                if (retCode == 0)
                {

                }
            }
            return IntPtr.Zero;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets the single instance of this class.
        /// This property is thread safe. 
        /// <see cref="https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff650316(v=pandp.10)?redirectedfrom=MSDN"/>
        /// </summary>
        public static GlobalHookManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new GlobalHookManager();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion
    }
}
