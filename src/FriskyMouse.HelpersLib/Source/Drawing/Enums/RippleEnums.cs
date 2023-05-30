using System.ComponentModel;
using FriskyMouse.HelpersLib.Attributes;

namespace FriskyMouse.HelpersLib.Drawing
{
    public enum RippleProfileType : uint
    {
        [Description("Expanding Ripple"), ConstructableEnum(typeof(CircleProfile))]
        Single,
        [Description("Expanding Square"), ConstructableEnum(typeof(SquareProfile))]
        Square,
        [Description("Hexagon"), ConstructableEnum(typeof(HexagonProfile))]
        Hexagon,
        [Description("Diamond"), ConstructableEnum(typeof(DiamondProfile))]
        Diamond,
        [Description("Cherry Blossom"), ConstructableEnum(typeof(SingleProfile))]
        Cherry,        
        [Description("Star ripple"), ConstructableEnum(typeof(StarProfile))]
        Star,        
        [Description("Fading Spotlight"), ConstructableEnum(typeof(SpotlightProfile))]
        Spotlight,
        [Description("Sonar Pulse"), ConstructableEnum(typeof(SonarPulseProfile))]
        SonarPulse,
        [Description("Squared Pulse"), ConstructableEnum(typeof(SquaredPulseProfile))]
        SquaredPulse,      
        [Description("Crosshair"), ConstructableEnum(typeof(CrosshairProfile))]
        Crosshair,
        [Description("Concentric Circles"), ConstructableEnum(typeof(ConcentricProfile))]
        Concentric // Core circle in the middle.          
    }

    public enum ShapeType : uint
    {
        Ellipse,        
        Rectangle,
        Polygon,
        Crosshair
    }

    public enum PolygonType : uint
    {
        Diamond,
        Hexagon,
        Star,
    }
}
