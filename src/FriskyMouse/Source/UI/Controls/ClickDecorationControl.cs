using System;
using System.Drawing;
using System.Windows.Forms;
using FriskyMouse.HelpersLib.Attributes;
using FrostyBee.FriskyRipples;
using FriskyMouse.Core;
using FriskyMouse.HelpersLib;
using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.HelpersLib.Helpers;

namespace FriskyMouse.UI.Controls
{
    public partial class ClickDecorationControl : UserControl
    {
        private readonly ValueAnimator _rippleValueAnimator;
        private readonly RippleProfilesManager _profilesManager;
        private readonly RippleProfileInfo _clickOptions;
        private BaseProfile _currentProfile;
        private Bitmap _canvas = null;
        private Bitmap _blankCanvas = null;
        private Graphics _graphics;

        public ClickDecorationControl()
        {
            InitializeComponent();
            // THE ISSUE IS HERE.
            //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            DoubleBuffered = true;
            _currentProfile = new FilledSonarPulseProfile();
            _profilesManager = DecorationController.Instance.ClickDecorator;
            _clickOptions = DecorationController.Instance.SettingsManager.ClickProfileOptions;
            _rippleValueAnimator = new ValueAnimator()
            {
                Increment = 0.010, // Control the animation speed.                                         
                Interpolation = InterpolationType.Linear
            };
            cmbProfilesList.SelectedIndexChanged += CmbProfilesList_SelectedIndexChanged;
            cmbAnimDirection.SelectedIndexChanged += CmbAnimDirection_SelectedIndexChanged;
            cmbInterpolationMode.SelectedIndexChanged += CmbInterpolationMode_SelectedIndexChanged;
            chkbColorTransition.CheckedChanged += ChkbColorTransition_CheckedChanged;
            _rippleValueAnimator.Progressed += OnRipplesAnimation_Progressed;
            _rippleValueAnimator.Completed += OnRipplesAnimation_Completed;
            sliderAnimSpeed.onValueChanged += SliderAnimSpeed_onValueChanged;
            switchEnableClicker.CheckedChanged += SwitchEnableClicker_CheckedChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            PopulateControls();
            base.OnLoad(e);
        }
        private void PopulateControls()
        {
            // Populate the combo box with the ripple profiles descriptions.            
            cmbProfilesList.PopulateFromEnum(typeof(RippleProfileType));
            cmbAnimDirection.PopulateFromEnum(typeof(AnimationDirection));
            cmbInterpolationMode.PopulateFromEnum(typeof(InterpolationType));
            //-- Create the drawing canvas on which the ripples will be drawn.
            _canvas = DrawingHelper.CreateBitmap(pcbRipplePreview.Width, pcbRipplePreview.Height, Color.White);
            _blankCanvas = DrawingHelper.CreateBitmap(pcbRipplePreview.Width, pcbRipplePreview.Height, Color.White);
            pcbRipplePreview.Image = _canvas;
            pcbRipplePreview.BackColor = Color.White;
            _graphics = Graphics.FromImage(_canvas);
            _graphics.SetAntiAliasing(); // Need to set it once.
        }
        private void StartAnimation()
        {
            pcbRipplePreview.Image = _canvas;
            //   StopAnimation();
            _rippleValueAnimator.StartNewAnimation(_clickOptions.AnimationDirection);
            if (!_rippleValueAnimator.IsAnimating())
            {
            }
        }
        private void StopAnimation()
        {
            if (_rippleValueAnimator.IsAnimating())
            {
                _rippleValueAnimator.Stop();
                // Clear the preview.
            }
        }
        private void OnRipplesAnimation_Progressed(object sender)
        {
            if (_rippleValueAnimator.IsAnimating())
            {
                _graphics.Clear(Color.White);
                // Draw and animate the selected profile. 
                var progress = _rippleValueAnimator.GetProgress();
                _currentProfile.RenderRipples(_graphics, _clickOptions, progress);
            }
            pcbRipplePreview.Invalidate();
        }
        private void OnRipplesAnimation_Completed(object sender)
        {
            // Clear the _canvas that was previously drawn onto the _layeredWindow window.                                    
            pcbRipplePreview.Image = _blankCanvas;
        }

        private void SwitchEnableClicker_CheckedChanged(object sender, EventArgs e)
        {
            _clickOptions.Enabled = switchEnableClicker.Checked;
        }
        private void CmbProfilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch to the newly selected profile. 
            RippleProfileType profileType = cmbProfilesList.ParseEnumValue<RippleProfileType>();
            BaseProfile _newProfile = ConstructableFactory.GetInstanceOf<BaseProfile>(profileType);
            _currentProfile?.Dispose();
            _profilesManager.SwitchProfile(_newProfile);
            _currentProfile = _newProfile;
            StartAnimation();
        }
        private void CmbAnimDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The direction of the animation has been changed.                                     
            _clickOptions.AnimationDirection = cmbAnimDirection.ParseEnumValue<AnimationDirection>();
            _profilesManager.ApplySettings(_clickOptions);
            StartAnimation();
        }
        private void CmbInterpolationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The animation's interpolation mode has been changed.                                     
            InterpolationType interpolation = cmbInterpolationMode.ParseEnumValue<InterpolationType>();
            _rippleValueAnimator.Interpolation = interpolation;
            _clickOptions.InterpolationType = interpolation;
            _profilesManager.ApplySettings(_clickOptions);
            // Adjust the animation speed based on the recommended value associated with the selected 
            // interpolation mode. 
            DefaultSpeedAttribute speedAttribute = interpolation.GetEnumAttribute<DefaultSpeedAttribute>();
            AdjustAnimationSpeed(speedAttribute.Speed);
            sliderAnimSpeed.Value = speedAttribute.Speed;
        }
        private void SliderAnimSpeed_onValueChanged(object sender, int newValue)
        {
            AdjustAnimationSpeed(newValue);
        }
        private void AdjustAnimationSpeed(int speed)
        {
            //lblAnimSpeed.Text = speed.ToString();
            sliderAnimSpeed.Value = speed;
            // Increase the animation speed.
            double speedRate = (double)speed / 1000;
            _rippleValueAnimator.Increment = speedRate;
            _clickOptions.AnimationSpeed = speedRate;
            _profilesManager.ApplySettings(_clickOptions);
        }

        private void BtnStopAnimation_Click(object sender, EventArgs e)
        {
            StopAnimation();
            _profilesManager.StopAnimation();
        }

        private void ChkbColorTransition_CheckedChanged(object sender, EventArgs e)
        {
            _clickOptions.CanFadeColor = chkbColorTransition.Checked;
            _currentProfile.ResetColorOpacity();
            StartAnimation();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            StartAnimation();
        }
    }
}

