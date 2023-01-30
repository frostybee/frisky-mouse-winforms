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
    internal class HighlightCircle
    {
        public HighlightCircle()
        {
            // Default settings. 
            Radius = 50;
            FillColor = Color.Yellow;
            Opacity = 200;
            IsFilled = true;
            OutlineWidth = 1f;
            OutlineStyle = DashStyle.Solid;
        }

        // Draw the highlighter.
        public void Draw(Graphics gr)
        {
            gr.DrawHighlighterPreview(this);
        }
        #region Properties
        public PointF Center { get; set; }
        public int Radius { get; set; }
        public int Opacity { get; set; }
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public bool IsFilled { get; set; }
        public float OutlineWidth { get; set; }
        public DashStyle OutlineStyle { get; set; } 
        #endregion
    }
}
