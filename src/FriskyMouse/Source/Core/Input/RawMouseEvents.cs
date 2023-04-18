using FriskyMouse.NativeApi;

namespace FriskyMouse.GlobalHooks
{
    public class RawMouseEvents
    {

        public MouseButtonTypes MessageType { get; set; } = MouseButtonTypes.None;
        public POINT Point { get; set; }
        public uint MouseData { get; set; } = 0;
        public uint TimeStamp { get; set; } = 0;

    }
}
