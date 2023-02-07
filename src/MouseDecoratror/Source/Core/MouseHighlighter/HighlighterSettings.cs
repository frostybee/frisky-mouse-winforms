using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MouseDecoratror.Core;

namespace MouseDecoratror.Core
{
    internal class HighlighterSettings
    {
        public HighlighterSettings()
        {
            // Default settings. 
            Radius = 50;
            FillColor = Color.Red;
            Opacity = 200;
            IsFilled = true;
            OutlineThickness = 3;
            OutlineStyle = DashStyle.Solid;
            OutlineColor = Color.Yellow;
            CenterX = 0;
            CenterY= 0;
        }

        // Draw the _highlighterSettings.
        // TODO: move to another class: need a centralized class that provides drawing services.
        public void Draw(Graphics gr)
        {
            gr.DrawHighlighter(this);
        }
        #region Properties
        public bool IsEnabled { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Radius { get; set; }
        public byte Opacity { get; set; }
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public bool IsFilled { get; set; }
        public int OutlineThickness { get; set; }
        public DashStyle OutlineStyle { get; set; } 
        #endregion
    }
}
