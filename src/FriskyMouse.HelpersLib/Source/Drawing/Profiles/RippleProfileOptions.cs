using FriskyMouse.HelpersLib.Animation;
using System.Drawing;

namespace FriskyMouse.HelpersLib.Drawing
{
    public class RippleProfileOptions
    {
        #region Animation Settings
        public InterpolationType InterpolationType { get; set; } = InterpolationType.Linear;
        public AnimationDirection AnimationDirection { get; set; } = AnimationDirection.In;
        public double AnimationSpeed { get; set; } = 0.020;
        #endregion        

        #region Visual Appearance
        public bool CanFadeColor { get; set; } = false;
        public int InitialOpacity { get; set; } = 100;
        public int MaxRadius { get; set; } = 200;
        public Color FillColor { get; set; } = Color.Yellow;
        public Color OutlineColor { get; set; } = Color.Red;
        #endregion
        public bool Enabled { get; set; } = true;
        public RippleProfileType CurrentRippleProfile { get; set; } = RippleProfileType.IceCream;
    }
}
