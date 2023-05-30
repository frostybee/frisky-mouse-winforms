using FriskyMouse.HelpersLib.Attributes;
using System.ComponentModel;

namespace FriskyMouse.HelpersLib.Animation
{
    public enum InterpolationType
    {
        [Description("Linear"), ConstructableEnum(typeof(InterpolatorLinear)), DefaultSpeed(25)]
        Linear,
        [Description("Ease Out"), ConstructableEnum(typeof(InterpolatorEaseOut)), DefaultSpeed(25)]
        EaseOut,
        [Description("In Out"), ConstructableEnum(typeof(InterpolatorEaseInOut)), DefaultSpeed(20)]
        InOut,
        [Description("In Exponential"), ConstructableEnum(typeof(InterpolatorInExpo)), DefaultSpeed(10)]
        InExpo,
        [Description("Out Exponential"), ConstructableEnum(typeof(InterpolatorOutExpo)), DefaultSpeed(30)]
        OutExpo,
        [Description("Out Back"), ConstructableEnum(typeof(InterpolatorOutBack)), DefaultSpeed(10)]
        OutBack,
        [Description("In Out Back"), ConstructableEnum(typeof(InterpolatorInOutBack)), DefaultSpeed(15)]
        InOutBack,
        [Description("In Cubic"), ConstructableEnum(typeof(InterpolatorInCubic)), DefaultSpeed(15)]
        InCubic,
        [Description("Out Cubic"), ConstructableEnum(typeof(InterpolatorOutCubic)), DefaultSpeed(15)]
        OutCubic,
        [Description("In Out Cubic"), ConstructableEnum(typeof(InterpolatorInOutCubic)), DefaultSpeed(20)]
        InOutCubic,
        [Description("Custom Quadratic"), ConstructableEnum(typeof(InterpolatorCustomQuadratic)), DefaultSpeed(20)]
        CustomQuadratic,
        [Description("In Elastic"), ConstructableEnum(typeof(InterpolatorInElastic)), DefaultSpeed(10)]
        InElastic,
        [Description("Out Elastic"), ConstructableEnum(typeof(InterpolatorOutElastic)), DefaultSpeed(10)]
        OutElastic,
        [Description("In Out Elastic"), ConstructableEnum(typeof(InterpolatorInOutElastic)), DefaultSpeed(12)]
        InOutElastic,
        [Description("In Bounce"), ConstructableEnum(typeof(InterpolatorInBounce)), DefaultSpeed(15)]
        InBounce,
        [Description("Out Bounce"), ConstructableEnum(typeof(InterpolatorOutBounce)), DefaultSpeed(20)]
        OutBounce,
        [Description("In Out Bounce"), ConstructableEnum(typeof(InterpolatorOutBounce)), DefaultSpeed(15)]
        InOutBounce,
        [Description("In Quint"), ConstructableEnum(typeof(InterpolatorInQuint)), DefaultSpeed(15)]
        InQuint,
        [Description("Out Quint"), ConstructableEnum(typeof(InterpolatorOutQuint)), DefaultSpeed(15)]
        OutQuint,
        [Description("In Out Quint"), ConstructableEnum(typeof(InterpolatorInOutQuint)), DefaultSpeed(17)]
        InOutQuint        
    }
}
