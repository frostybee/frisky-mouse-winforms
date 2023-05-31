using FriskyMouse.HelpersLib.Animation;


namespace FriskyMouse.HelpersLib.Drawing
{
    public class ProfileOptions
    {
        #region Animation Settings
        public InterpolationType InterpolationType { get; set; } = InterpolationType.Linear;
        public AnimationDirection AnimationDirection { get; set; } = AnimationDirection.In;
        public double AnimationSpeed { get; set; } = 0.010;
        #endregion        

        #region Visual Appearance
        public bool CanFadeColor { get; set; } = false;
        public int InitialOpacity { get; set; } = 100;
        public int MaxRadius { get; set; }
        #endregion
    }
}
