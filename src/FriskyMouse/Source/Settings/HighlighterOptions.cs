using FriskyMouse.Helpers;

namespace FriskyMouse.Settings
{
    public class HighlighterOptions
    {
        #region Properties        
        public bool Enabled { get; set; } = true;        
        public int Radius { get; set; } = 25;
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public bool IsFilled { get; set; } = true;
        public Color FillColor { get; set; } = Color.Yellow;
        public byte OpacityPercentage { get; set; } = 50;
        public byte Opacity
        {
            get
            {                
                return (byte)(Math.Min(OpacityPercentage * 255 / 100, 255));
            }
        }        
        public bool IsOutlined { get; set; } = false;
        public Color OutlineColor { get; set; } = Color.Red;        
        public int OutlineWidth { get; set; } = 2;
        public OutlineStyle OutlineStyle { get; set; } = OutlineStyle.Solid;
        public bool HasShadow { get; set; } = false;
        public int ShadowDepth { get; set; } = 5;
        public Color ShadowColor { get; set; } = Color.CornflowerBlue;
        public byte ShadowOpacityPercentage { get; set; } = 50;
        public byte ShadowOpacity
        {
            get
            {
                return (byte)(Math.Min(ShadowOpacityPercentage * 255 / 100, 255));
            }
        }
        #endregion
    }
}
