#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.NativeApi;

internal class NativeConstants
{
    #region Constants
    public const int SW_SHOWNOACTIVATE = 8;
    public const int SW_HIDE = 0;
    public const int ULW_ALPHA = 2;
    public const byte AC_SRC_OVER = 0x00;
    public const byte AC_SRC_ALPHA = 0x01;
    public const int WS_POPUP = 0x8000000;
    public const int GWL_EXSTYLE = -20;
    public const int WS_EX_TOPMOST = 0x0008;
    #endregion
}
