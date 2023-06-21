using FriskyMouse.Core;
using MaterialSkin;

namespace FriskyMouse.UI.Controls
{
    public partial class AppSettingsControl : UserControl
    {
        private int colorSchemeIndex = 0;
        private readonly MaterialSkinManager materialSkinManager;
        private readonly DecorationController _applicationManager;
        public AppSettingsControl()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            _applicationManager = DecorationController.Instance;
        }

        private void UpdateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red400,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepPurple800,
                        Primary.DeepPurple900,
                        Primary.DeepPurple500,
                        Accent.DeepPurple400,
                        TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepOrange800,
                        Primary.DeepOrange900,
                        Primary.DeepOrange500,
                        Accent.DeepOrange200,
                        TextShade.WHITE);
                    break;
                case 5:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Teal800,
                        Primary.Teal900,
                        Primary.Teal500,
                        Accent.Teal700,
                        TextShade.WHITE);
                    break;
                case 6:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Orange800,
                        Primary.Orange900,
                        Primary.Orange500,
                        Accent.Orange700,
                        TextShade.WHITE);
                    break;
                case 7: // Very good one. 
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Red400,
                        Primary.Red900,
                        Primary.Red500,
                        Accent.Red400,
                        TextShade.WHITE);
                    break;
            }
            _applicationManager.MainForm?.Invalidate();
        }
        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 7)
                colorSchemeIndex = 0;
            UpdateColor();
        }

        private void SwitchChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = switchChangeTheme.Checked ?
                MaterialSkinManager.Themes.DARK :
                MaterialSkinManager.Themes.LIGHT;
        }
    }
}
