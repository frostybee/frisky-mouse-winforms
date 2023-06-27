using FriskyMouse.Drawing.Attributes;
using FriskyMouse.Core;
using FriskyMouse.Drawing;
using FriskyMouse.Drawing.Animation;
using FriskyMouse.Drawing.Ripples;
using FriskyMouse.Drawing.Extensions;
using FriskyMouse.Drawing.Helpers;
using FriskyMouse.Settings;
using FriskyMouse.Helpers;
using FriskyMouse.Extensions;

namespace FriskyMouse.UI.Controls
{
    public partial class ClickDecorationControl : UserControl
    {
        private readonly ValueAnimator _rippleValueAnimator;
        private ClickEffectController _profileManager;
        private RippleProfileOptions _settings;
        private BaseRippleProfile _currentProfile;
        private Bitmap? _canvas;
        private Bitmap? _blankCanvas;
        private Graphics? _graphics;

        public ClickDecorationControl()
        {
            InitializeComponent();
            // THE UI scaling ISSUE IS HERE.
            //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            DoubleBuffered = true;
            _currentProfile = new FilledSonarPulseProfile();
            _rippleValueAnimator = new ValueAnimator()
            {
                Increment = 0.010, // Control the animation speed.                                         
                Interpolation = InterpolationType.Linear
            };
            _rippleValueAnimator.Progressed += OnRipplesAnimation_Progressed;
            _rippleValueAnimator.Completed += OnRipplesAnimation_Completed;
        }
        private void InitControlsEvents()
        {
            cmbProfilesList.SelectedIndexChanged += CmbProfilesList_SelectedIndexChanged;
            cmbAnimDirection.SelectedIndexChanged += CmbAnimDirection_SelectedIndexChanged;
            cmbInterpolationMode.SelectedIndexChanged += CmbInterpolationMode_SelectedIndexChanged;
            sliderAnimSpeed.onValueChanged += SliderAnimSpeed_onValueChanged;
            sldRadiusMultiplier.onValueChanged += SldRadiusMultiplier_onValueChanged;
            sldOpacityMultiplier.onValueChanged += SwitchOpacityMultiplier_onValueChanged;
            switchClickDecoration.CheckedChanged += SwitchClickDecoration_CheckedChanged;
            switchColorTransition.CheckedChanged += SwitchColorTransition_CheckedChanged;
            btnColorPicker.Click += BtnColorPicker_Click;
        }


        internal void UpdateControlsFromSettings(string title, ClickEffectController profileManager, RippleProfileOptions options)
        {
            lblControlTitle.Text = title;
            _profileManager = profileManager;
            _settings = options;
            cmbInterpolationMode.SelectedIndex = cmbInterpolationMode.GetItemIndexByEumValue(_settings.InterpolationType);
            cmbAnimDirection.SelectedIndex = cmbAnimDirection.GetItemIndexByEumValue(_settings.AnimationDirection);
            cmbProfilesList.SelectedIndex = cmbProfilesList.GetItemIndexByEumValue(_settings.CurrentRippleProfile);
            sliderAnimSpeed.Value = (int)(_settings.AnimationSpeed * 1000);
            switchColorTransition.Checked = _settings.CanFadeColor;
            switchClickDecoration.Checked = _settings.IsEnabled;
            btnFillColor.BackColor = _settings.FillColor;
            sldRadiusMultiplier.Value = _settings.RadiusMultiplier;
            sldOpacityMultiplier.Value = _settings.OpacityMultiplier;
            AppHelpers.UpdateSwitchText(switchClickDecoration);
            //--> 
            LoadRipplesProfile();
            InitControlsEvents();
            //-- Animation settings.
            _rippleValueAnimator.Interpolation = _settings.InterpolationType;
            StartAnimation();
        }

        private void LoadRipplesProfile()
        {
            SwitchRippleProfile(_settings.CurrentRippleProfile);
            AdjustAnimationSpeed((int)(_settings.AnimationSpeed * 1000));
        }

        private void AdjustAnimationSpeed(int speed)
        {
            //lblAnimSpeed.Text = speed.ToString();
            //sliderAnimSpeed.Value = speed;
            _settings.AnimationSpeed = speed;
            // Increase the animation speed.
            double speedRate = (double)speed / 1000;
            _rippleValueAnimator.Increment = speedRate;
            _settings.AnimationSpeed = speedRate;
            sliderAnimSpeed.Value = speed;
            _profileManager.ApplySettings(_settings);
        }

        private void SwitchRippleProfile(RippleProfileType profileType)
        {
            BaseRippleProfile _newProfile = ConstructableFactory.GetInstanceOf<BaseRippleProfile>(profileType);
            _currentProfile?.Dispose();
            _currentProfile = _newProfile;
            _profileManager.SwitchProfile(_newProfile);
            _settings.CurrentRippleProfile = profileType;
            _currentProfile.UpdateRipplesStyle(_settings);
        }
        private void BtnColorPicker_Click(object? sender, EventArgs e)
        {
            Color selectedColor = Helpers.AppHelpers.GetUserSelectedColor(_settings.FillColor);
            _settings.FillColor = selectedColor;
            btnFillColor.BackColor = selectedColor;
            _currentProfile?.UpdateRipplesStyle(_settings);
            StartAnimation();
        }

        protected override void OnLoad(EventArgs e)
        {
            PopulateControls();
            InitializeDrawingCanvas();
            base.OnLoad(e);
        }
        private void PopulateControls()
        {
            // Populate the combo box with the ripple profiles descriptions.            
            cmbProfilesList.PopulateFromEnum<RippleProfileType>();
            cmbAnimDirection.PopulateFromEnum<AnimationDirection>();
            cmbInterpolationMode.PopulateFromEnum<InterpolationType>();
        }

        private void InitializeDrawingCanvas()
        {
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
            _currentProfile.ResetColorOpacity();
            //   StopAnimation();
            _rippleValueAnimator.StartNewAnimation(_settings.AnimationDirection);
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
                _graphics?.Clear(Color.White);
                // Draw and animate the selected profile. 
                var progress = _rippleValueAnimator.GetProgress();
                _currentProfile.RenderRipples(_graphics, _settings, progress);
            }
            pcbRipplePreview.Invalidate();
        }
        private void OnRipplesAnimation_Completed(object sender)
        {
            // Clear the _canvas that was previously drawn onto the _layeredWindow window.                                    
            //pcbRipplePreview.Image = _blankCanvas;
        }

        private void SwitchClickDecoration_CheckedChanged(object sender, EventArgs e)
        {
            _settings.IsEnabled = switchClickDecoration.Checked;
            AppHelpers.UpdateSwitchText(switchClickDecoration);
        }
        private void CmbProfilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch to the newly selected profile. 
            RippleProfileType profileType = cmbProfilesList.GetSelectedEnumValue<RippleProfileType>();
            SwitchRippleProfile(profileType);
            StartAnimation();
        }


        private void CmbAnimDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The direction of the animation has been changed.                                     
            _settings.AnimationDirection = cmbAnimDirection.GetSelectedEnumValue<AnimationDirection>();
            _profileManager.ApplySettings(_settings);
            StartAnimation();
        }
        private void CmbInterpolationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The animation's saved easing mode has been changed.                                     
            InterpolationType interpolation = cmbInterpolationMode.GetSelectedEnumValue<InterpolationType>();
            _rippleValueAnimator.Interpolation = interpolation;
            _settings.InterpolationType = interpolation;
            _profileManager.ApplySettings(_settings);
            // Adjust the animation speed based on the recommended value associated with the selected 
            // savedEasing mode. 
            DefaultSpeedAttribute speedAttribute = interpolation.GetEnumAttribute<DefaultSpeedAttribute>();
            AdjustAnimationSpeed(speedAttribute.Speed);
            // TODO: Display the recommended speed in a label instead.
            //sliderAnimSpeed.Value = speedAttribute.Speed;
            StartAnimation();
        }
        private void SldRadiusMultiplier_onValueChanged(object sender, int newValue)
        {
            if (newValue < 5)
            {
                sldRadiusMultiplier.Value = 5;
                newValue = 5;
            }
            _settings.RadiusMultiplier = newValue;
        }
        private void SwitchOpacityMultiplier_onValueChanged(object sender, int newValue)
        {
            _settings.OpacityMultiplier = newValue;
        }

        private void SliderAnimSpeed_onValueChanged(object sender, int newValue)
        {
            if (newValue < 10)
            {
                sliderAnimSpeed.Value = 10;
                newValue = 10;
            }
            AdjustAnimationSpeed(newValue);
        }

        private void BtnStopAnimation_Click(object sender, EventArgs e)
        {
            StopAnimation();
            _profileManager.StopAnimation();
        }

        private void SwitchColorTransition_CheckedChanged(object sender, EventArgs e)
        {
            _settings.CanFadeColor = switchColorTransition.Checked;
            _currentProfile.ResetColorOpacity();
            StartAnimation();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            StartAnimation();
        }
    }
}

