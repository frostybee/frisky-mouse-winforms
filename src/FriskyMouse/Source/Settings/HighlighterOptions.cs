using System.Drawing.Drawing2D;


namespace FriskyMouse.Core
{
    public class HighlighterOptions
    {
        #region Properties
        public bool Enabled { get; set; } = true;
        public bool IsOutlined { get; set; } = true;
        public bool HasShadow { get; set; } = true;
        public int Radius { get; set; } = 50;
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public byte OpacityPercentage { get; set; } = 50;
        public byte Opacity
        {
            get
            {
                return (byte)(Math.Min(OpacityPercentage * 255 / 100, 255));
            }
        }
        public bool IsFilled { get; set; } = true;
        public Color FillColor { get; set; } = Color.Yellow;
        public Color OutlineColor { get; set; } = Color.Red;        
        public int OutlineWidth { get; set; } = 2;
        public int ShadowWidth { get; set; } = 5;
        public DashStyle OutlineStyle { get; set; } = DashStyle.Solid;
        #endregion
    }
}
