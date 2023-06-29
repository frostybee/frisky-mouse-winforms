using FriskyMouse.NativeApi;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FriskyMouse.Core
{
    internal class HookProcedureSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public HookProcedureSafeHandle()
            : base(true)
        {
        }

        protected override bool ReleaseHandle()
        {
            var ret = NativeMethods.UnhookWindowsHookEx(handle);
            if (ret != 0)
            {
                base.Dispose();
                return true;
            }
            return true;
        }
    }
}
