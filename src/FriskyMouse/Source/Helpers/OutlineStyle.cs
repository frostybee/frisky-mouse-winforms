using System.ComponentModel;

namespace FriskyMouse.Helpers
{
    public enum OutlineStyle: uint
    {
        [Description("Solid")]
        Solid = 0,
        [Description("Dashed")]
        Dash = 1,
        [Description("Dotted")]
        Dot = 2,
        [Description("Dash Dot")]
        DashDot = 3,
        [Description("Dash Dot Dot")]
        DashDotDot = 4        
    }
}
