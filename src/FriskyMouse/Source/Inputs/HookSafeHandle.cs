#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
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
    internal class HookSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public HookSafeHandle()
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
