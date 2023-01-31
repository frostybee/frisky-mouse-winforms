using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bee.GlobalHooks.NativeApi
{   
    
    /// <summary>
    /// Message types that are posted to the window that has caputred the mouse actions.
    /// <see cref="https://docs.microsoft.com/en-us/windows/win32/inputdev/mouse-input-notifications"/>
    /// </summary>
    public enum MouseButtonTypes
    {
        None = 0x0,
        /// <summary>
        /// The left mouse button is down.
        /// </summary>
        LeftButtonDown = 0x0201,
        /// <summary>
        /// The left mouse button is up.
        /// </summary>
        LeftButtonUp = 0x0202,
        /// <summary>
        /// Left mouse button double-click.
        /// </summary>
        LeftButtonDoubleClick = 0x0203,
        /// <summary>
        /// The mouse has been moved.
        /// </summary>
        MouseMove = 0x0200,
        MouseWheel = 0x020A,
        /// <summary>
        /// The right mouse button is down.
        /// </summary>
        RightButtonDown = 0x0204,
        /// <summary>
        /// The right mouse button is up.
        /// </summary>
        RightButtonUp = 0x0205
    }
    /// <summary>
    /// The POINT structure defines the x- and y- coordinates of a point.
    /// <see cref="https://docs.microsoft.com/en-us/previous-versions/dd162805(v=vs.85)"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
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


}
