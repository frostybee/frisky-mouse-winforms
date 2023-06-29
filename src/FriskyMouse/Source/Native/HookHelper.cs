#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace FriskyMouse.GlobalHooks.Native
{
    internal class HookHelper
    {
        //TODO: @see: https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.marshal.getlastwin32error?view=net-5.0
        public static void VerifyNativeMethod()
        {
            //Returns the error code returned by the last unmanaged function called using platform invoke that has the DllImportAttribute.SetLastError flag set. 
            int errorCode = Marshal.GetLastWin32Error();
            //Initializes and throws a new instance of the Win32Exception class with the specified error. 
            throw new Win32Exception(errorCode);
        }
    }
}
