using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkin
{   
    public interface IShadowedMaterialControl : IMaterialControl
    {
        int Depth { get; set; }
        int Elevation { get; set; }

        GraphicsPath ShadowBorder { get; set; }
        MaterialSkinManager SkinManager { get; }
        MouseState MouseState { get; set; }
    }
     
}
