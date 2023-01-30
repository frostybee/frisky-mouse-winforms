using Bee.GlobalHooks.NativeApi;

namespace Bee.GlobalHooks
{
    public class RawMouseEventArgs
    {

        public MouseButtonTypes MessageType { get; set; } = MouseButtonTypes.None;
        public POINT Point { get; set; }
        public uint MouseData { get; set; } = 0;
        public uint TimeStamp { get; set; } = 0;

    }
}
