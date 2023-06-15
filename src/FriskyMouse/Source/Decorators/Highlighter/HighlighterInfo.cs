using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace FriskyMouse.Core
{
    internal class HighlighterInfo
    {
        #region Properties
        public bool Enabled { get; set; } = true;
        public bool IsForPreview { get; set; } = false;
        public int Radius { get; set; } = 50;
        public byte OpacityPercentage { get; set; } = 50;
        public byte Opacity
        {
            get
            {
                return (byte)(Math.Min(OpacityPercentage * 255 / 100, 255));
            }
        }
        public Color FillColor { get; set; } = Color.Yellow;
        public Color OutlineColor { get; set; } = Color.Red;
        public bool IsFilled { get; set; } = true;
        public int OutlineThickness { get; set; } = 1;
        public DashStyle OutlineStyle { get; set; } = DashStyle.Solid;
        #endregion
    }
}
