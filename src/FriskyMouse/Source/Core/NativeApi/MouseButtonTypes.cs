using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostybee.GlobalHooks.NativeApi
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
}
