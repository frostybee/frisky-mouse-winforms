using System.Drawing;

namespace FriskyMouse.MouseDecorator.Core
{
    internal class BitmapStyleInfo
    {
        public enum ShapeTypes
        {
            Circle,
            Rectangle,
            Triangle
        }
      
        public bool IsFilled { get; set; }
        public int Size { get; set; }
        public int PenSize { get; set; }
        public byte Opacity { get; set; }
        public Color Color { get; set; }
        public ShapeTypes Shape { get; set; }
    }
}
