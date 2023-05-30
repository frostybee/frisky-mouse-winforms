using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace FriskyMouse.Core
{
    internal class HighlighterSettings
    {
        // TODO: convert this into a ripple entry.
        public HighlighterSettings()
        {
            // Default settings. 
            Radius = 50;
            FillColor = Color.Red;
            OpacityPercentage = 50;
            IsFilled = true;
            OutlineThickness = 3;
            OutlineStyle = DashStyle.Solid;
            OutlineColor = Color.Yellow;
            CenterX = 0;
            CenterY = 0;
        }

        public Rectangle GetRectangle()
        {
            int x = (IsForPreview) ? CenterX - Radius : 0;
            int y = (IsForPreview) ? CenterY - Radius : 0;
            int width = Radius * 2;
            if (!IsFilled)
            {
                // TODO: fix the issue with the not filled circle.
                // If a not filled circle to be drawn, we need to consider
                // the thickness of the outline when computing the size of the rectangle.
                x += OutlineThickness;
                //width += OutlineThickness;

            }
            return new Rectangle(x, x, width, width);
        }

        // Draw the _highlighterModel.
        // TODO: move to another class: need a centralized class that provides drawing services.
        public void Draw(Graphics gr)
        {
            gr.DrawSpotlight(this);
        }

        #region Properties
        public bool IsEnabled { get; set; }
        public bool IsForPreview { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
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
        public int OutlineThickness { get; set; }
        public DashStyle OutlineStyle { get; set; }
        #endregion
    }
}
