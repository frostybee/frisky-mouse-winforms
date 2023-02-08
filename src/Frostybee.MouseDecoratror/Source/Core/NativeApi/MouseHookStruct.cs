using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Frostybee.GlobalHooks.NativeApi
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


}
