using FriskyMouse.NativeApi;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace FriskyMouse.Core
{
    public abstract class GlobalInputsHook
    {
        protected int _hookType;
        protected IntPtr _handleToHook;
        protected bool _isStarted;
        private NativeMethods.HookProc _hookCallback = null;

        #region Methods

        public void Install()
        {

            if (!_isStarted &&
                _hookType != 0 && _handleToHook == IntPtr.Zero)
            {
                if (_handleToHook == IntPtr.Zero)
                {
                    // Make sure we keep a reference to this delegate!
                    // If not, GC randomly collects it, and a NullReference exception is thrown
                    _hookCallback = new NativeMethods.HookProc(HookCallbackProcedure);

                    _handleToHook = NativeMethods.SetWindowsHookEx(
                        NativeMethods.WH_MOUSE_LL,
                        _hookCallback,
                        NativeMethods.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName),
                        0);
                    if (_handleToHook == IntPtr.Zero)
                    {
                        int errorCode = Marshal.GetLastWin32Error();
                        throw new Win32Exception(errorCode);
                    }
                }

                // Were we able to successfully start hook?
                if (_handleToHook != IntPtr.Zero)
                {
                    _isStarted = true;
                }
            }
        }

        public void Uninstall()
        {
            if (_isStarted)
            {
                // If it's set, uninstall the mouse hook.
                if (_handleToHook != IntPtr.Zero)
                {
                    bool retCode = NativeMethods.UnhookWindowsHookEx(_handleToHook);
                    _handleToHook = IntPtr.Zero;
                    _hookCallback = null;
                    if (!retCode)
                    {
                        int errorCode = Marshal.GetLastWin32Error();
                        throw new Win32Exception(errorCode);
                    }
                }
                _isStarted = false;
            }
        }

        protected virtual IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // This method must be overridden by each extending hook
            return IntPtr.Zero;

        }
        #endregion

        #region Properties
        public bool Started => _isStarted;
        #endregion
    }
}
