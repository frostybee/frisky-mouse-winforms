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

using FriskyMouse.Helpers;
using FriskyMouse.NativeApi;
using System.Runtime.InteropServices;

namespace FriskyMouse.Core;

internal class MouseHookController : GlobalMouseHook
{
    private int _systemDoubleClickTime;
    private HighlighterController _highlighter;
    private ClickEffectController _clickDecorator;
    private ClickEffectController _rightClickDecorator;
    private static object _syncRoot = new Object();
    private IntPtr _mouseHookHandle = IntPtr.Zero;
    public MouseHookController(HighlighterController highlighter, ClickEffectController clickDecorator,
        ClickEffectController rightClickDecorator)
    {
        _highlighter = highlighter;
        _clickDecorator = clickDecorator;
        _rightClickDecorator = rightClickDecorator;
        _systemDoubleClickTime = SystemInformation.DoubleClickTime;
        _hookType = WH_MOUSE_LL;
    }

    protected override IntPtr HookCallbackProcedure(int nCode, IntPtr wParam, IntPtr lParam)
    {
        MouseButtonTypes messageType = (MouseButtonTypes)wParam;

        if (nCode < 0)
        {
            return NativeMethods.CallNextHookEx(_mouseHookHandle, nCode, wParam, lParam);
        }
        if (nCode >= 0)
        {            
            MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
            POINT cursorPos = FMAppHelpers.GetCursorPosition();
            switch (messageType)
            {
                case MouseButtonTypes.LeftButtonDown:
                    _clickDecorator.ShowRipplesAt(hookStruct.pt);
                    //_clickDecorator.ShowRipplesAt(cursorPos);
                    break;
                case MouseButtonTypes.LeftButtonUp:
                    // Fix the issue when the highlighter is no longer top most.
                    // TODO: lock the involved objects. This is causing an InvalidOperationException.
                    Task.Delay(500).ContinueWith(t => _highlighter?.BringToFront());
                    break;
                case MouseButtonTypes.MouseMove:
                    //POINT cursorPos = FMAppHelpers.GetCursorPosition();
                    //_highlighter?.MoveSpotlight(cursorPos);
                    _highlighter?.MoveSpotlight(hookStruct.pt);

                    break;
                case MouseButtonTypes.RightButtonUp:
                    // Fix the issue when the highlighter is no longer top most.                        
                    Task.Delay(400).ContinueWith(t => _highlighter?.BringToFront());
                    //Task.Delay(200).ContinueWith(t => _rightClickDecorator?.SetTopMost(hookStruct.pt.X, hookStruct.pt.Y));                    
                    _rightClickDecorator.ShowRipplesAt(hookStruct.pt);
                    //_rightClickDecorator.ShowRipplesAt(cursorPos);
                    //_options.BringToFront(hookStruct.pt);
                    /*_leftClickDecorator?.DecorateLeftSingleClick(new RawMouseEvents
                    {
                        MessageType = (MouseButtonTypes)wParam,
                        Point = hookStruct.pt,
                        MouseData = hookStruct.mouseData,
                        TimeStamp = hookStruct.time
                    });*/
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
                    //Debug.WriteLine("Mouse moved..." + hookStruct.pt.X);
                    break;
                default:
                    break;
            }

        }
        return NativeMethods.CallNextHookEx(_mouseHookHandle, nCode, wParam, lParam);
    }
}

