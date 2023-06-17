using FriskyMouse.Core;
using FriskyMouse.HelpersLib;
using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.UI;
using System.Drawing.Imaging;

namespace FriskyMouse.Core
{
    /// <summary>
    /// Responsible for creating, switching and animating ripple profiles. 
    /// 
    /// A ripple profile consists of a drawing that is either to be drawn or animated. 
    /// It maintains ripple instances corresponding to what the user has selected/enabled.
    /// The profiles maintained are left click, right click, and double click ripple profiles. 
    /// </summary>
    internal class RippleProfilesAnimator: IDisposable
    {
        private readonly LayeredWindow _layeredWindow;
        // NOTE: move those to the RippleProfile.
        private Bitmap _canvas = null;
        /// <summary>
        /// Blank bitmap used to clear previous drawings 
        /// </summary>
        private Bitmap _blankCanvas = null;
        /// <summary>        
        /// The drawing canvas on which the mouse click ripples will be animated.
        /// </summary>
        private Graphics _graphics;
        private readonly ValueAnimator _animationManager;
        private RippleProfile _currentRipplesProfile;
        private readonly RippleProfileOptions _settings;
        
        private bool disposedValue;
        public RippleProfileType RippleType { get; set; }

        public RippleProfilesAnimator(RippleProfileOptions settings)
        {
            _settings = settings;
            _layeredWindow = new LayeredWindow();                        
            // Default ripple profile.
            RippleType = RippleProfileType.FilledSonarPulse;
            _currentRipplesProfile = ConstructableFactory.GetInstanceOf<RippleProfile>(RippleProfileType.SquaredPulse);
            _animationManager = new ValueAnimator()
            {
                Increment = 0.040,
                Interpolation = InterpolationType.Linear

            };
            _animationManager.Progressed += RipplesAnimation_Progressed;
            _animationManager.Completed += RipplesAnimation_Finished;
            InitDrawingCanvas();
        }

        private void InitDrawingCanvas()
        {
            if (_canvas == null)
            {
                _canvas = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _blankCanvas = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
                _graphics = Graphics.FromImage(_canvas);
                _graphics.SetAntiAliasing();
            }
        }

        public void SwitchProfile(RippleProfile ripplesProfile)
        {
            _currentRipplesProfile = ripplesProfile;
        }

        private void RipplesAnimation_Progressed(object sender)
        {
            // We process the animation frames here. 
            // We perform the drawing here.                        
            // TODO: put this in a helper method.                                    
            double progress = _animationManager.GetProgress();
            _graphics.Clear(Color.Transparent);
            _currentRipplesProfile.RenderRipples(_graphics, _settings, progress);
            // Update the layered window to show the current frame. 
            _layeredWindow.SetBitmap(_canvas, 255);
        }

        private RippleProfile MakeDrawingProfile(RippleProfileType inProfileType)
        {
            RippleProfile rippleProfile = ConstructableFactory.GetInstanceOf<RippleProfile>(inProfileType);
            return rippleProfile;
        }

        private void RipplesAnimation_Finished(object sender)
        {
                        // Clear the _canvas that was previously drawn onto the _layeredWindow window.
            _graphics.Clear(Color.Transparent);
            _layeredWindow.Hide();
            _layeredWindow.SetBitmap(_blankCanvas, 0);            
        }

        internal void ShowRipplesAt(int x, int y)
        {
            if (_settings.Enabled)
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
                _animationManager.StartNewAnimation(_settings.AnimationDirection);
            }
        }

        internal void ApplySettings(RippleProfileOptions options)
        {
            _animationManager.Increment = options.AnimationSpeed;
            _animationManager.Interpolation = options.InterpolationType;
        }

        internal void StopAnimation()
        {
            if (_animationManager.IsAnimating())
            {
                _animationManager.Stop();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _canvas?.Dispose();
                    _blankCanvas?.Dispose();
                    _animationManager.Dispose();
                    _layeredWindow?.Dispose();                    
                    _canvas = null;
                    _blankCanvas = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RippleProfilesAnimator()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
