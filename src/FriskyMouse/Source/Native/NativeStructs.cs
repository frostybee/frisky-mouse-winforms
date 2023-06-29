#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using System.Runtime.InteropServices;

namespace FriskyMouse.NativeApi
{

    /// <summary>
    /// Contains information about a low-level mouse input event.
    /// <see cref="https://docs.microsoft.com/en-gb/windows/win32/api/winuser/ns-winuser-msllhookstruct?redirectedfrom=MSDN"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct MSLLHOOKSTRUCT
    {
        /// <summary>
        /// The x- and y-coordinates of the cursor, in per-monitor-aware screen coordinates.
        /// </summary>
        public POINT pt;
        /// <summary>
        /// Holds information about the mouse's actions such as button pressed, mouse moved, etc.
        /// </summary>
        public uint mouseData;
        /// <summary>
        /// The event-injected flags.
        /// </summary>
        public uint flags;
        /// <summary>
        /// The time stamp for this message.
        /// </summary>
        public uint time;
        /// <summary>
        /// Additional information associated with the message.
        /// </summary>
        public IntPtr dwExtraInfo;
    }

    /// <summary>
    /// The POINT structure defines the x- and y- coordinates of a point.
    /// <see cref="https://docs.microsoft.com/en-us/previous-versions/dd162805(v=vs.85)"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public static readonly POINT Empty;

        /// <summary>
        ///     Specifies the X-coordinate of the point.
        /// </summary>
        public int X;

        /// <summary>
        ///     Specifies the Y-coordinate of the point.
        /// </summary>
        public int Y;

        public POINT(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(POINT a, POINT b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(POINT a, POINT b)
        {
            return !(a == b);
        }

        public bool Equals(POINT other)
        {
            return other.X == X && other.Y == Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != typeof(POINT)) return false;
            return Equals((POINT)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
    public struct Size
    {
        public int cx;
        public int cy;

        public Size(int cx, int cy)
        {
            this.cx = cx;
            this.cy = cy;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ARGB
    {
        public byte Blue;
        public byte Green;
        public byte Red;
        public byte Alpha;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }
}
