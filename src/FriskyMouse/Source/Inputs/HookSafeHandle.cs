#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.NativeApi;
using Microsoft.Win32.SafeHandles;

namespace FriskyMouse.Core;

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
