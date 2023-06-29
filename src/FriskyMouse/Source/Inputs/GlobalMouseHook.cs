using FriskyMouse.NativeApi;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace FriskyMouse.Core
{
    internal abstract class GlobalMouseHook
    {
        protected int _hookType;
        protected HookProcedureSafeHandle? _hookHandle;
        protected bool _isStarted;
        private NativeMethods.HookProc? _hookCallback = null;

        #region Methods

        public void Install()
        {

            if (!_isStarted &&
                _hookType != 0 && _hookHandle == null)
            {
                // Make sure we keep a reference to this delegate!
                // If not, GC randomly collects it, and a NullReference exception is thrown
                _hookCallback = new NativeMethods.HookProc(HookCallbackProcedure);

                _hookHandle = NativeMethods.SetWindowsHookEx(
                    _hookType,
                    _hookCallback,
                    NativeMethods.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName),
                    0);
                if (_hookHandle.IsInvalid)
                    ThrowLastUnmanagedErrorAsException();

                // Were we able to successfully start hook.
                if (!_hookHandle.IsInvalid)
                {
                    _isStarted = true;
                }
            }
        }

        public void Uninstall()
        {
            if (_isStarted)
            {
                if (_hookHandle != null && !_hookHandle.IsInvalid)
                {
                    _hookHandle.Dispose();
                }
                _isStarted = false;
            }
        }
        protected void ThrowLastUnmanagedErrorAsException()
        {
            var errorCode = Marshal.GetLastWin32Error();
            throw new Win32Exception(errorCode);
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
