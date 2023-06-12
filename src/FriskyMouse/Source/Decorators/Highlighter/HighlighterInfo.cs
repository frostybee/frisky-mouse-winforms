using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace FriskyMouse.Core
{
    internal class HighlighterInfo
    {
        // TODO: convert this into a ripple entry.
        public HighlighterInfo()
        {
            // Default settings. 
            Radius = 50;
            FillColor = Color.Red;
            OpacityPercentage = 50;
            IsFilled = true;
            OutlineThickness = 3;
            OutlineStyle = DashStyle.Solid;
            OutlineColor = Color.Yellow;            
        }
            

        #region Properties
        public bool Enabled { get; set; }
        public bool IsForPreview { get; set; }        
        public int Radius { get; set; }
        public byte OpacityPercentage { get; set; }
        public byte Opacity
        {
            get
            {
                return (byte)(Math.Min(OpacityPercentage * 255 / 100, 255));
            }
        }
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public bool IsFilled { get; set; }
        public int OutlineThickness { get; set; } = 1;
        public DashStyle OutlineStyle { get; set; }
        #endregion
    }
}
