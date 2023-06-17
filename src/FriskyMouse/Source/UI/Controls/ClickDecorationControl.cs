using FriskyMouse.HelpersLib.Attributes;
using FriskyMouse.Core;
using FriskyMouse.HelpersLib;
using FriskyMouse.HelpersLib.Animation;
using FriskyMouse.HelpersLib.Drawing;
using FriskyMouse.HelpersLib.Extensions;
using FriskyMouse.HelpersLib.Helpers;
using FriskyMouse.Settings;

namespace FriskyMouse.UI.Controls
{
    public partial class ClickDecorationControl : UserControl
    {
        private readonly ValueAnimator _rippleValueAnimator;
        private readonly RippleProfilesAnimator _profileManager;
        private readonly RippleProfileOptions _settings;
        private RippleProfile _currentProfile;
        private Bitmap? _canvas = null;
        private Bitmap? _blankCanvas = null;
        private Graphics? _graphics;

        public ClickDecorationControl()
        {
            InitializeComponent();
            // THE UI scaling ISSUE IS HERE.
            //AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            DoubleBuffered = true;
            _currentProfile = new FilledSonarPulseProfile();
            _profileManager = DecorationController.Instance.ClickDecorator;
            _settings = SettingsManager.Settings.LeftClickOptions;
            _rippleValueAnimator = new ValueAnimator()
            {
                Increment = 0.010, // Control the animation speed.                                         
                Interpolation = InterpolationType.Linear
            };
        }
        private void InitControlsEvents()
        {
            cmbProfilesList.SelectedIndexChanged += CmbProfilesList_SelectedIndexChanged;
            cmbAnimDirection.SelectedIndexChanged += CmbAnimDirection_SelectedIndexChanged;
            cmbInterpolationMode.SelectedIndexChanged += CmbInterpolationMode_SelectedIndexChanged;
            switchColorTransition.CheckedChanged += SwitchColorTransition_CheckedChanged;
            _rippleValueAnimator.Progressed += OnRipplesAnimation_Progressed;
            _rippleValueAnimator.Completed += OnRipplesAnimation_Completed;
            sliderAnimSpeed.onValueChanged += SliderAnimSpeed_onValueChanged;
            switchEnableClicker.CheckedChanged += SwitchEnableClicker_CheckedChanged;
        }

        internal void InitControlsFromSettings()
        {
            sliderAnimSpeed.Value = (int)(_settings.AnimationSpeed * 1000);
            cmbInterpolationMode.SelectedIndex = cmbInterpolationMode.GetItemIndexByEumValue(_settings.InterpolationType);
            cmbAnimDirection.SelectedIndex = cmbAnimDirection.GetItemIndexByEumValue(_settings.AnimationDirection);
            cmbProfilesList.SelectedIndex = cmbProfilesList.GetItemIndexByEumValue(_settings.CurrentRippleProfile);
            switchColorTransition.Checked = _settings.CanFadeColor;
            SwitchRippleProfile(_settings.CurrentRippleProfile);
            AdjustAnimationSpeed((int)(_settings.AnimationSpeed * 1000));
            //_profileManager.SwitchProfile()
            InitControlsEvents();
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
            _profileManager.ApplySettings(_settings);
        }

        private void SwitchRippleProfile(RippleProfileType profileType)
        {
            RippleProfile _newProfile = ConstructableFactory.GetInstanceOf<RippleProfile>(profileType);
            _currentProfile?.Dispose();
            _profileManager.SwitchProfile(_newProfile);
            _currentProfile = _newProfile;
            _settings.CurrentRippleProfile = profileType;
        }
        private void BtnColorPicker_Click(object? sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorPicker.AllowFullOpen = true;
            colorPicker.FullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorPicker.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorPicker.Color = btnColorPicker.BackColor;

            // Update the text box color if the user clicks OK 
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                _settings.FillColor = colorPicker.Color;
                _currentProfile.ApplySelectedColor(_settings);
                //UpdateHighlighterPreview();
                btnColorPicker.BackColor = colorPicker.Color;
            }
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
            pcbRipplePreview.Image = _blankCanvas;
        }

        private void SwitchEnableClicker_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Enabled = switchEnableClicker.Checked;
        }
        private void CmbProfilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch to the newly selected profile. 
            RippleProfileType profileType = cmbProfilesList.GetEnumValue<RippleProfileType>();
            SwitchRippleProfile(profileType);
            StartAnimation();
        }
               

        private void CmbAnimDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The direction of the animation has been changed.                                     
            _settings.AnimationDirection = cmbAnimDirection.GetEnumValue<AnimationDirection>();
            _profileManager.ApplySettings(_settings);
            StartAnimation();
        }
        private void CmbInterpolationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The animation's savedEasing mode has been changed.                                     
            InterpolationType interpolation = cmbInterpolationMode.GetEnumValue<InterpolationType>();
            _rippleValueAnimator.Interpolation = interpolation;
            _settings.InterpolationType = interpolation;
            _profileManager.ApplySettings(_settings);
            // Adjust the animation speed based on the recommended value associated with the selected 
            // savedEasing mode. 
            DefaultSpeedAttribute speedAttribute = interpolation.GetEnumAttribute<DefaultSpeedAttribute>();
            AdjustAnimationSpeed(speedAttribute.Speed);
            // TODO: Display the recommended speed in a label instead.
            //sliderAnimSpeed.Value = speedAttribute.Speed;
        }
        private void SliderAnimSpeed_onValueChanged(object sender, int newValue)
        {
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

