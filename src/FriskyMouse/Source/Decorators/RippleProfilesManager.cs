using FriskyMouse.Core;
using FriskyMouse.HelpersLib;
using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.UI;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

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
        private readonly LayeredWindow _layeredWindow;
        // NOTE: move those to the BaseProfile.
        private Bitmap _surface = null;
        /// <summary>
        /// Blank bitmap used to clear previous drawings 
        /// </summary>
        private Bitmap _blankCanvas = null;
        /// <summary>        
        /// The drawing canvas on which the mouse click ripples will be repeatedly drawn.
        /// </summary>
        private Graphics _graphics;
        private readonly ValueAnimator _animationManager;
        private BaseProfile _clickProfile;
        private readonly ClickProfileOptions _clickOptions;
        public RippleProfileType RippleType { get; set; }
        public RippleProfilesManager(SettingsManager _settingsManager)
        {
            _clickOptions = _settingsManager.ClickProfileOptions;
            _layeredWindow = new LayeredWindow();
            RippleType = RippleProfileType.FilledSonarPulse;

            _animationManager = new ValueAnimator()
            {
                Increment = 0.010,
                Interpolation = InterpolationType.BounceEaseOut

            };
            _animationManager.Progressed += RipplesAnimation_Progressed;
            _animationManager.Completed += RipplesAnimation_Finished;
            _clickProfile = ConstructableFactory.GetInstanceOf<BaseProfile>(RippleProfileType.SquaredPulse);
            InitDrawingCanvas();
        }

        private void InitDrawingCanvas()
        {
            if (_surface == null)
            {
                _surface = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _blankCanvas = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _graphics = Graphics.FromImage(_surface);
                _graphics.SetAntiAliasing();
            }
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
            double progress = _animationManager.GetProgress();
            _graphics.Clear(Color.Transparent);
            _clickProfile.RenderRipples(_graphics, _clickOptions, progress);
            // Update the layered window to show the current frame. 
            _layeredWindow.SetBitmap(_surface, 255);
        }

        private BaseProfile MakeDrawingProfile(RippleProfileType inProfileType)
        {
            BaseProfile rippleProfile = ConstructableFactory.GetInstanceOf<BaseProfile>(inProfileType);
            return rippleProfile;
        }

        private void RipplesAnimation_Finished(object sender)
        {
            //_layeredWindow.SetBitmap(new Bitmap(200, 200), 1);
            // Clear the _surface that was previously drawn onto the _layeredWindow window.
            _graphics.Clear(Color.Transparent);
            _layeredWindow.Hide();
            //_layeredWindow.SetBitmap(_blankCanvas, 0);            
        }

        internal void ShowRipplesAt(int x, int y)
        {
            if (_clickOptions.Enabled)
            {
                if (_animationManager.IsAnimating())
                {
                    _animationManager.Stop();
                }
                if (!_animationManager.IsAnimating())
                {                    
                    _layeredWindow.Move(x + 1, y + 1);
                    _layeredWindow.Show();
                    StartAnimation();
                }
            }
        }

        internal void StartAnimation()
        {
            // We perform the drawing here.            
            if (!_animationManager.IsAnimating())
            {
                _layeredWindow.SetBitmap(_blankCanvas, 1);
                //_animationManager.StartNewAnimation(AnimationDirection.InOutIn);
                _animationManager.StartNewAnimation(_clickOptions.AnimationDirection);
            }
        }

        internal void ApplySettings(ClickProfileOptions profileSettings)
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
