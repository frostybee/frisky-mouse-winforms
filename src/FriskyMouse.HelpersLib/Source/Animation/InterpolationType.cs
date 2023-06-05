using FriskyMouse.HelpersLib.Attributes;
using FrostyBee.FriskyRipples.Animation;
using System.ComponentModel;

namespace FriskyMouse.HelpersLib.Animation
{
    public enum InterpolationType
    {
        [Description("Linear Easing"), ConstructableEnum(typeof(LinearEasing)), DefaultSpeed(25)]
        Linear,
        [Description("Back In"), ConstructableEnum(typeof(BackEaseIn)), DefaultSpeed(25)]
        BackEaseIn,
        [Description("Back Out"), ConstructableEnum(typeof(BackEaseOut)), DefaultSpeed(10)]
        BackEaseOut,
        [Description("Back In Out"), ConstructableEnum(typeof(BackEaseInOut)), DefaultSpeed(20)]
        BackEaseInOut,
        [Description("Bounce In"), ConstructableEnum(typeof(BounceEaseIn)), DefaultSpeed(30)]
        BounceEaseIn,
        [Description("Bounce Out"), ConstructableEnum(typeof(BounceEaseOut)), DefaultSpeed(10)]
        BounceEaseOut,
        [Description("Bounce In Out"), ConstructableEnum(typeof(BounceEaseInOut)), DefaultSpeed(10)]
        BounceEaseInOut,

        [Description("Circular In"), ConstructableEnum(typeof(CircularEaseIn)), DefaultSpeed(10)]
        CircularEaseIn,
        [Description("Circular Out"), ConstructableEnum(typeof(CircularEaseOut)), DefaultSpeed(10)]
        CircularEaseOut,
        [Description("Circular In Out"), ConstructableEnum(typeof(CircularEaseInOut)), DefaultSpeed(10)]
        CircularEaseInOut,

        [Description("Cubic In"), ConstructableEnum(typeof(CubicEaseIn)), DefaultSpeed(10)]
        CubicEaseIn,
        [Description("Cubic Out"), ConstructableEnum(typeof(CubicEaseOut)), DefaultSpeed(10)]
        CubicEaseOut,
        [Description("Cubic In Out"), ConstructableEnum(typeof(CubicEaseInOut)), DefaultSpeed(10)]
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


        [Description("Quartic In"), ConstructableEnum(typeof(QuarticEaseIn)), DefaultSpeed(10)]
        QuarticEaseIn,
        [Description("Quartic Out"), ConstructableEnum(typeof(QuarticEaseOut)), DefaultSpeed(10)]
        QuarticEaseOut,
        [Description("Quartic In Out"), ConstructableEnum(typeof(QuarticEaseInOut)), DefaultSpeed(10)]
        QuarticEaseInOut,


        [Description("Quintic In"), ConstructableEnum(typeof(QuinticEaseIn)), DefaultSpeed(10)]
        QuinticEaseIn,
        [Description("Quintic Out"), ConstructableEnum(typeof(QuinticEaseOut)), DefaultSpeed(10)]
        QuinticEaseOut,
        [Description("Quintic In Out"), ConstructableEnum(typeof(QuinticEaseInOut)), DefaultSpeed(10)]
        QuinticEaseInOut,

        [Description("Sine In"), ConstructableEnum(typeof(SineEaseIn)), DefaultSpeed(10)]
        SineEaseIn,
        [Description("Sine Out"), ConstructableEnum(typeof(SineEaseOut)), DefaultSpeed(10)]
        SineEaseOut,
        [Description("Sine In Out"), ConstructableEnum(typeof(SineEaseInOut)), DefaultSpeed(10)]
        SineEaseInOut,
    }
}
