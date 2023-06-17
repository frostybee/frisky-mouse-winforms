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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using static System.Windows.Forms.CheckedListBox;

namespace FriskyMouse.UI.Controls
{
    public partial class ClickDecorationControl : UserControl
    {
        private readonly ValueAnimator _rippleValueAnimator;
        private readonly RippleProfilesAnimator _profilesManager;
        private readonly RippleProfileOptions _clickOptions;
        private readonly ApplicationSettings _settingsManager;
        private BaseProfile _currentProfile;
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
            _profilesManager = DecorationController.Instance.ClickDecorator;
            _settingsManager = DecorationController.Instance.ApplicationSettings;
            _clickOptions = DecorationController.Instance.ApplicationSettings.LeftClickOptions;
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
                _clickOptions.FillColor = colorPicker.Color;
                _currentProfile.ApplySelectedColor(_clickOptions);
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

        internal void InitControlsFromSettings()
        {
            sliderAnimSpeed.Value = (int)(_clickOptions.AnimationSpeed * 1000);
            cmbInterpolationMode.SelectedIndex = cmbInterpolationMode.GetItemIndexByEumValue(_clickOptions.InterpolationType);
            cmbAnimDirection.SelectedIndex = cmbAnimDirection.GetItemIndexByEumValue(_clickOptions.AnimationDirection);
            cmbProfilesList.SelectedIndex = cmbProfilesList.GetItemIndexByEumValue(_clickOptions.CurrentRippleProfile);
            //_profilesManager.SwitchProfile()
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
                _graphics?.Clear(Color.White);
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
            _clickOptions.CurrentRippleProfile = profileType;
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
            // The animation's savedEasing mode has been changed.                                     
            InterpolationType interpolation = cmbInterpolationMode.ParseEnumValue<InterpolationType>();
            _rippleValueAnimator.Interpolation = interpolation;
            _clickOptions.InterpolationType = interpolation;
            _profilesManager.ApplySettings(_clickOptions);
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
        private void AdjustAnimationSpeed(int speed)
        {
            //lblAnimSpeed.Text = speed.ToString();
            //sliderAnimSpeed.Value = speed;
            _clickOptions.AnimationSpeed = speed;
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

