using FriskyMouse.NativeApi;

using FriskyMouse.HelpersLib.Animation;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using FriskyMouse.HelpersLib.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.UI;
using FriskyMouse.HelpersLib;

namespace FrostyBee.FriskyRipples
{
    /// <summary>
    /// Responsible for creating, switching and animating ripple profiles. 
    /// 
    /// A ripple profile consists of a drawing that is either to be drawn or animated. 
    /// It maintains ripple instances corresponding to what the user has selected/enabled.
    /// The profiles maintained are left click, right click, and double click ripple profiles. 
    /// </summary>
    internal class RippleProfilesManager
    {

        readonly LayeredWindow _layeredWindow;
        // NOTE: move those to the BaseProfile.
        private Bitmap _surface = null;
        private Bitmap _blankSurface = null;
        /// <summary>        
        /// The drawing canvas on which the mouse click ripples will be repeatedly drawn.
        /// </summary>
        private Graphics _graphics;
        private readonly ValueAnimator _animationManager;
        private BaseProfile _clickProfile;        
        public RippleProfileType RippleType { get; set; }
        public RippleProfilesManager()
        {
            /* 
             * TODO: Include in the settings: 
             * - Flag: expandable ripple or not.
             * - Flag: color transition or not. 
             * NOTE: I can remove the specialized profiles and put 
             *      all the ripple instantiation in the BaseProfile class.
             */
            _layeredWindow = new LayeredWindow();                        
            RippleType = RippleProfileType.SonarPulse;

            _animationManager = new ValueAnimator()
            {
                Increment = 0.020, // Control the animation duration.
                //Increment = 0.010,                
                //InterpolationType = InterpolationType.EaseOut,                
                //InterpolationType = InterpolationType.InElastic
                Interpolation = InterpolationType.OutBounce

            };            
            _animationManager.Progressed += RipplesAnimation_Progressed;
            _animationManager.Completed += RipplesAnimation_Finished;
            _clickProfile = ConstructableFactory.GetInstanceOf<BaseProfile>(RippleProfileType.SquaredPulse);

        }

        public void SwitchProfile(BaseProfile inProfile)
        {            
            _clickProfile = inProfile;
        }

        private void RipplesAnimation_Progressed(object sender)
        {
            // We process the animation frames here. 
            // We perform the drawing here.                        
            // TODO: put this in a helper method.                        
            Debug.WriteLine(_animationManager.GetProgress());
            var progress = _animationManager.GetProgress();
            _graphics.Clear(Color.Transparent);
            _clickProfile.RenderRipples(_graphics, progress);
            //RenderRipplesProfile(_clickProfile, progress);
            _layeredWindow.SetBitmap(_surface, 255);
        }
        
        private BaseProfile MakeDrawingProfile(RippleProfileType inProfileType)
        {
            BaseProfile rippleProfile = ConstructableFactory.GetInstanceOf<BaseProfile>(inProfileType);            
            return rippleProfile;
        }

        private void RipplesAnimation_Finished(object sender)
        {
            //-- Long lasting ripple: show it and hide on finish. 
            Debug.WriteLine("Finished....");
            //_layeredWindow.SetBitmap(new Bitmap(200, 200), 1);
            // Clear the _surface that was previously drawn onto the _layeredWindow window.
            //_layeredWindow.SetBitmap(_blankCanvas, 1);
            _graphics.Clear(Color.Transparent);
            _layeredWindow.Hide();
        }
     
        internal void ShowRipplesAt()
        {
            NativeMethods.GetCursorPos(out POINT p);
            _layeredWindow.PositionX = p.X +1 ;
            _layeredWindow.PositionY = p.Y +1;
            _layeredWindow.Move();
            _layeredWindow.Show();
            StartAnimation();            
        }
        
        internal void StartAnimation()
        {

            if (_surface == null)
            {
                // Init the drawing _surface first.
                // Need to be disposed.
                // Check memory consumption of this version.
                //_surface = DrawingHelper.CreateBitmap(300, 300, Color.White);
                _surface = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _blankSurface = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _graphics = Graphics.FromImage(_surface);
                _graphics.SetAntiAliasing();                
            }
            // Clear the _surface that was previously drawn onto the _layeredWindow window.
            _layeredWindow.SetBitmap(_blankSurface, 1);
            //Debug.WriteLine("Updating....");
            // We perform the drawing here.            


            /*animate.Start(1000, 1, 1000, EasingType.QuadOut);
            animate.Complete = objAnimationManager_OnAnimationFinished;
            animate.Update = OnAnimationUpdated;*/
            //animate.Start(1000);
            if (!_animationManager.IsAnimating())
            {                
                //_animationManager.StartNewAnimation(AnimationDirection.InOutIn);
                _animationManager.StartNewAnimation(_clickProfile.Options.AnimationDirection);
            }

        }        

        internal void ApplySettings(ProfileOptions profileSettings)
        {
            _animationManager.Increment = profileSettings.AnimationSpeed;
            _animationManager.Interpolation = profileSettings.InterpolationType;            
        }

        internal void StopAnimation()
        {
            if (_animationManager.IsAnimating())
            {
                _animationManager.Stop();
            }
        }
    }
}
