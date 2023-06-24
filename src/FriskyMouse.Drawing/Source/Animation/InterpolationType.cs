using FriskyMouse.Drawing.Attributes;
using System.ComponentModel;

namespace FriskyMouse.Drawing.Animation
{
    public enum InterpolationType : uint
    {
        [Description("Linear Easing"), ConstructableEnum(typeof(LinearEasing)), DefaultSpeed(25)]
        Linear,
        [Description("Back In"), ConstructableEnum(typeof(BackEaseIn)), DefaultSpeed(25)]
        BackEaseIn,
        [Description("Back Out"), ConstructableEnum(typeof(BackEaseOut)), DefaultSpeed(10)]
        BackEaseOut,
        [Description("Back In Out"), ConstructableEnum(typeof(BackEaseInOut)), DefaultSpeed(20)]
        BackEaseInOut,
        [Description("Bounce In"), ConstructableEnum(typeof(BounceEaseIn)), DefaultSpeed(20)]
        BounceEaseIn,
        [Description("Bounce Out"), ConstructableEnum(typeof(BounceEaseOut)), DefaultSpeed(20)]
        BounceEaseOut,
        [Description("Bounce In Out"), ConstructableEnum(typeof(BounceEaseInOut)), DefaultSpeed(10)]
        BounceEaseInOut,
        [Description("Circular In"), ConstructableEnum(typeof(CircularEaseIn)), DefaultSpeed(15)]
        CircularEaseIn,
        [Description("Circular Out"), ConstructableEnum(typeof(CircularEaseOut)), DefaultSpeed(15)]
        CircularEaseOut,
        [Description("Circular In Out"), ConstructableEnum(typeof(CircularEaseInOut)), DefaultSpeed(15)]
        CircularEaseInOut,
        [Description("Cubic In"), ConstructableEnum(typeof(CubicEaseIn)), DefaultSpeed(15)]
        CubicEaseIn,
        [Description("Cubic Out"), ConstructableEnum(typeof(CubicEaseOut)), DefaultSpeed(15)]
        CubicEaseOut,
        [Description("Cubic In Out"), ConstructableEnum(typeof(CubicEaseInOut)), DefaultSpeed(15)]
        CubicEaseInOut,
        [Description("Elastic In"), ConstructableEnum(typeof(ElasticEaseIn)), DefaultSpeed(10)]
        ElasticEaseIn,
        [Description("Elastic Out"), ConstructableEnum(typeof(ElasticEaseOut)), DefaultSpeed(10)]
        ElasticEaseOut,
        [Description("Elastic In Out"), ConstructableEnum(typeof(ElasticEaseInOut)), DefaultSpeed(10)]
        ElasticEaseInOut,
        [Description("Exponential In"), ConstructableEnum(typeof(ExponentialEaseIn)), DefaultSpeed(10)]
        ExponentialEaseIn,
        [Description("Exponential Out"), ConstructableEnum(typeof(ExponentialEaseOut)), DefaultSpeed(10)]
        ExponentialEaseOut,
        [Description("Exponential In Out"), ConstructableEnum(typeof(ExponentialEaseInOut)), DefaultSpeed(10)]
        ExponentialEaseInOut,
        [Description("Quadratic In"), ConstructableEnum(typeof(QuadraticEaseIn)), DefaultSpeed(10)]
        QuadraticEaseIn,
        [Description("Quadratic Out"), ConstructableEnum(typeof(QuadraticEaseOut)), DefaultSpeed(10)]
        QuadraticEaseOut,
        [Description("Quadratic In Out"), ConstructableEnum(typeof(QuadraticEaseInOut)), DefaultSpeed(10)]
        QuadraticEaseInOut,
        [Description("Quartic In"), ConstructableEnum(typeof(QuarticEaseIn)), DefaultSpeed(15)]
        QuarticEaseIn,
        [Description("Quartic Out"), ConstructableEnum(typeof(QuarticEaseOut)), DefaultSpeed(15)]
        QuarticEaseOut,
        [Description("Quartic In Out"), ConstructableEnum(typeof(QuarticEaseInOut)), DefaultSpeed(15)]
        QuarticEaseInOut,
        [Description("Quintic In"), ConstructableEnum(typeof(QuinticEaseIn)), DefaultSpeed(15)]
        QuinticEaseIn,
        [Description("Quintic Out"), ConstructableEnum(typeof(QuinticEaseOut)), DefaultSpeed(15)]
        QuinticEaseOut,
        [Description("Quintic In Out"), ConstructableEnum(typeof(QuinticEaseInOut)), DefaultSpeed(15)]
        QuinticEaseInOut,
        [Description("Sine In"), ConstructableEnum(typeof(SineEaseIn)), DefaultSpeed(15)]
        SineEaseIn,
        [Description("Sine Out"), ConstructableEnum(typeof(SineEaseOut)), DefaultSpeed(15)]
        SineEaseOut,
        [Description("Sine In Out"), ConstructableEnum(typeof(SineEaseInOut)), DefaultSpeed(15)]
        SineEaseInOut,
    }
}
