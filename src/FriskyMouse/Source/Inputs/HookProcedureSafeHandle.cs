#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

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
