
using FriskyMouse.HelpersLib.Animation;
using System;
using System.Windows.Forms;

namespace FriskyMouse.HelpersLib.Animation
{
    /// <summary>
    /// 
    /// </summary>
    public class ValueAnimator
    {
        #region Animation Properties
        private Easing _interpolator;
        /// <summary>
        /// Gets or sets a value indicating whether InterruptAnimation
        /// </summary>
        public bool InterruptAnimation { get; set; }

        /// <summary>
        /// Gets/sets the value by which the progress of the animation is increased.         
        /// </summary>
        public double Increment { get; set; }

        /// <summary>
        /// Gets or sets the SecondaryIncrement
        /// </summary>
        public double SecondaryIncrement { get; set; }

        /// <summary>
        /// Sets the Interpolation mode of the animation.
        /// When is set, an instance of the selected interpolator will be created. 
        /// </summary>
        public InterpolationType Interpolation
        {
            set
            {
                SetInterpolator(value);
            }
        }
        #endregion

        public delegate void CompletedEventHandler(object sender);

        /// <summary>
        /// Occurs when the animation's progress value reaches the target value.
        /// The target value is 0 if the animation direction is In.
        /// The target value is 1 if the animation direction is Out.
        /// </summary>
        public event CompletedEventHandler Completed;

        public delegate void ProgressedEventHandler(object sender);

        /// <summary>
        /// Occurs whenever the animation progresses inward or outward over time.
        /// </summary>
        public event ProgressedEventHandler Progressed;

        /// <summary>
        /// Holds the values that indicates the progress of the animation.
        /// The value ranges between 0 and 1. 
        /// </summary>
        private double _progress = 0;

        /// <summary>
        /// Defines the _animationDirections
        /// </summary>
        private AnimationDirection _direction = AnimationDirection.In;

        /// <summary>
        /// The lower bound of the animation progress.
        /// </summary>
        private const double MIN_VALUE = 0.00;

        /// <summary>
        /// The upper bound of the animation progress.
        /// </summary>
        private const double MAX_VALUE = 1.00;

        /// <summary>
        /// Controls the animation progress within the specified interval. 
        /// </summary>
        private readonly Timer _animationTimer = new Timer { Interval = 5, Enabled = false };

        public ValueAnimator()
        {
            Increment = 0.03;
            SecondaryIncrement = 0.03;
            Interpolation = InterpolationType.Linear;
            InterruptAnimation = true;
            // Set the animation direction to inward by default. 
            _direction = AnimationDirection.In;
            _animationTimer.Tick += AnimationTimer_OnTick;
        }

        /// <summary>
        /// Starts a new animation.
        /// If the spe
        /// </summary>
        /// <param name="direction">The direction of the animation.</param>
        public void StartNewAnimation(AnimationDirection direction)
        {
            if (!IsAnimating() || InterruptAnimation)
            {
                _progress =
                    (direction == AnimationDirection.Out ||
                    direction == AnimationDirection.InOutOut) ? MAX_VALUE : MIN_VALUE;
                _direction = direction;
                _animationTimer.Start();
            }
        }

        private void AnimationTimer_OnTick(object sender, EventArgs eventArgs)
        {
            UpdateProgress();
            ResetDirection();
            Progressed?.Invoke(this);
        }

        private void ResetDirection()
        {
            if ((_direction == AnimationDirection.InOutIn && _progress == MAX_VALUE))
            {
                _direction = AnimationDirection.InOutOut;
            }
            else if ((_direction == AnimationDirection.InOutRepeatingIn && _progress == MAX_VALUE))
            {
                _direction = AnimationDirection.InOutRepeatingOut;
            }
            else if ((_direction == AnimationDirection.InOutRepeatingOut && _progress == MIN_VALUE))
            {
                _direction = AnimationDirection.InOutRepeatingIn;
            }
        }
              

        /// <summary>
        /// Updates the progress of the animation. 
        /// The progress value will be either incremented or decremented depending
        /// on the current direction of the animation.
        /// </summary>
        /// <exception cref="Exception">
        /// Throws an exception if no animation direction is specified.
        /// </exception>
        private void UpdateProgress()
        {
            switch (_direction)
            {
                case AnimationDirection.InOutRepeatingIn:
                case AnimationDirection.InOutIn:
                case AnimationDirection.In:
                    IncrementProgress();
                    break;

                case AnimationDirection.InOutRepeatingOut:
                case AnimationDirection.InOutOut:
                case AnimationDirection.Out:
                    DecrementProgress();
                    break;

                default:
                    throw new Exception("No AnimationDirection has been set");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void IncrementProgress()
        {
            _progress += Increment;
            if (_progress > MAX_VALUE)
            {
                // The animation progressed outward and has reached 1. 
                _progress = MAX_VALUE;
                if (IsLooping())
                {
                    return;
                }
                if ((_direction == AnimationDirection.InOutOut
                    || _direction == AnimationDirection.In)
                    && _progress != MAX_VALUE)
                {
                    return;
                }

                _animationTimer.Stop();
                Completed?.Invoke(this);
            }
        }        

        /// <summary>
        /// 
        /// </summary>
        private void DecrementProgress()
        {
            _progress -= (_direction == AnimationDirection.InOutOut ||
                _direction == AnimationDirection.InOutRepeatingOut) ? SecondaryIncrement : Increment;
            if (_progress < MIN_VALUE)
            {
                // The animation progressed inward and has reached 0. 
                _progress = MIN_VALUE;

                if (IsLooping())
                {
                    return;
                }
                if ((_direction == AnimationDirection.InOutOut
                    || _direction == AnimationDirection.Out)
                    && _progress != MIN_VALUE)
                {
                    return;
                }
                _animationTimer.Stop();
                Completed?.Invoke(this);
            }
        }
        private bool IsLooping()
        {
            return (_direction == AnimationDirection.InOutIn
                    || _direction == AnimationDirection.InOutRepeatingIn
                    || _direction == AnimationDirection.InOutRepeatingOut);
        }
        /// <summary>
        /// Determines whether the animation is running or not.
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public bool IsAnimating()
        {
            return _animationTimer.Enabled;
        }
        /// <summary>
        /// Interpolates and returns the progressed value of the animation.
        /// The returned values ranges between 0 and 1.
        /// </summary>
        /// <returns>An interpolated value between 0 and 1.</returns>
        public double GetProgress()
        {
            return _interpolator.Ease(_progress);
        }

        /// <summary>
        /// Stops the actively running animation and fires the OnFinished event.
        /// </summary>
        public void Stop()
        {
            _animationTimer.Stop();
            Completed?.Invoke(this);
        }

        /// <summary>
        /// Creates an instance of an interpolator specified by its enum type.
        /// </summary>
        /// <param name="pInterpolatorType">The type of interpolator to be instantiated.</param>
        private void SetInterpolator(InterpolationType pInterpolatorType)
        {            
            Easing newInterpolator = ConstructableFactory.GetInstanceOf<Easing>(pInterpolatorType);
            // Create a linear interpolator if the dynamic instantiation fails.
            _interpolator = newInterpolator ?? new LinearEasing();
        }

        public void Dispose()
        {
            _animationTimer.Tick -= AnimationTimer_OnTick;
            _animationTimer?.Dispose();            
        }
    }
}