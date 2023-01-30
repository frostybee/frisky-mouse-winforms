namespace WinApiWrappers
{
    /// <summary>
    /// An enum containing the list of extended window styles as defined in window.h
    /// <see cref="https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles"/>
    /// </summary>
    public enum WindowExtendedStyles : int
    {
        AcceptFiles = 0x10,
        AppWindow = 0x40000,
        ClientEdge = 0x200,
        Composited = 0x2000000,
        ContextHelp = 0x400,
        ControlParent = 0x10000,
        DlgModalFrame = 0x1,
        LayoutRtl = 0x400000,
        Left = 0x0,
        LeftScrollBar = 0x4000,
        LtrReading = 0x0,
        Layered = 0x80000,
        MdiChild = 0x40,
        NoActivate = 0x8000000,
        NoInheritlayout = 0x100000,
        NoParentnotify = 0x4,
        OverLappedWindow = WindowEdge | ClientEdge,
        PaletteWindow = WindowEdge | ToolWindow | TopMost,
        Right = 0x1000,
        RightScrollbar = 0x0,
        RtlReading = 0x2000,
        StaticEdge = 0x20000,
        ToolWindow = 0x80,
        TopMost = 0x8,
        Transparent = 0x20,
        WindowEdge = 0x100
    }
}