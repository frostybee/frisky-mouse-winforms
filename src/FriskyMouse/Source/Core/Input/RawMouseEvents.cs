using FriskyMouse.NativeApi;

namespace FriskyMouse.GlobalHooks
{
    public class RawMouseEvents
    {

        public NativeEnums MessageType { get; set; } = NativeEnums.None;
        public POINT Point { get; set; }
        public uint MouseData { get; set; } = 0;
        public uint TimeStamp { get; set; } = 0;

    }
}
