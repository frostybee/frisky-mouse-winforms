using System.ComponentModel;

namespace FriskyMouse.HelpersLib.Animation
{
    /// <summary>
    /// Defines the direction of the animation.
    /// </summary>
    public enum AnimationDirection
    {
        [Description("In")]
        In, //In. Stops if finished.
        [Description("Out")]
        Out, //Out. Stops if finished.
        [Description("In Out In")]
        InOutIn, //Same as In, but changes to InOutOut if finished.
        [Description("In Out Out")]
        InOutOut, //Same as Out.
        [Description("In Out Repeating In")]
        InOutRepeatingIn, // Same as In, but changes to InOutRepeatingOut if finished.
        [Description("In Out Repeating Out ")]
        InOutRepeatingOut // Same as Out, but changes to InOutRepeatingIn if finished.
    }    
}
