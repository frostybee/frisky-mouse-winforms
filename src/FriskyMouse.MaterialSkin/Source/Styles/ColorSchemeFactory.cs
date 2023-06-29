namespace MaterialSkin
{
    public static class ColorSchemeFactory
    {
        public static ColorScheme GetColorScheme(ColorSchemeType schemeType)
        {
            ColorScheme colorScheme = new ColorScheme();
            switch (schemeType)
            {
                case ColorSchemeType.Red:
                    colorScheme = new ColorScheme(
                        Primary.Red400,
                        Primary.Red900,
                        Primary.Red500,
                        Accent.Red400,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Pink:
                    colorScheme = new ColorScheme(
                        Primary.Pink700,
                        Primary.Pink900,
                        Primary.Pink500,
                        Accent.Pink200,
                        TextShade.WHITE
                        );
                    break;
                case ColorSchemeType.Purple:
                    colorScheme = new ColorScheme(
                    Primary.Purple700,
                        Primary.Purple900,
                        Primary.Purple500,
                        Accent.Purple200,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.DeepPurple:
                    colorScheme = new ColorScheme(
                        Primary.DeepPurple800,
                        Primary.DeepPurple900,
                        Primary.DeepPurple500,
                        Accent.DeepPurple400,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Indigo:
                    colorScheme = new ColorScheme(
                    Primary.Indigo800,
                    Primary.Indigo900,
                    Primary.Indigo500,
                    Accent.Pink200,
                    TextShade.WHITE);
                    break;
                case ColorSchemeType.Blue:
                    colorScheme = new ColorScheme(
                    Primary.Blue800,
                    Primary.Blue900,
                    Primary.Blue500,
                    Accent.Blue400,
                    TextShade.WHITE);
                    break;
                case ColorSchemeType.LightBlue:
                    colorScheme = new ColorScheme(
                    Primary.LightBlue800,
                    Primary.LightBlue900,
                    Primary.LightBlue500,
                    Accent.LightBlue400,
                    TextShade.WHITE);
                    break;
                case ColorSchemeType.Cyan:
                    colorScheme = new ColorScheme(
                        Primary.Cyan800,
                        Primary.Cyan900,
                        Primary.Cyan500,
                        Accent.Cyan700,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Teal:
                    colorScheme = new ColorScheme(
                        Primary.Teal800,
                        Primary.Teal900,
                        Primary.Teal500,
                        Accent.Teal700,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Green:
                    colorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green500,
                        Accent.Red400,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.LightGreen:
                    colorScheme = new ColorScheme(
                       Primary.LightGreen800,
                       Primary.LightGreen900,
                       Primary.LightGreen500,
                       Accent.Red400,
                       TextShade.WHITE);
                    break;                                  
                case ColorSchemeType.Orange:
                    colorScheme = new ColorScheme(
                        Primary.Orange800,
                        Primary.Orange900,
                        Primary.Orange500,
                        Accent.Orange700,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.DeepOrange:
                    colorScheme = new ColorScheme(
                        Primary.DeepOrange800,
                        Primary.DeepOrange900,
                        Primary.DeepOrange500,
                        Accent.DeepOrange200,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Brown:
                    colorScheme = new ColorScheme(
                        Primary.Brown600,
                        Primary.Brown900,
                        Primary.Brown500,
                        Accent.LightBlue700,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.Grey:
                    colorScheme = new ColorScheme(
                        Primary.Grey800,
                        Primary.Grey900,
                        Primary.Grey500,
                        Accent.LightBlue700,
                        TextShade.WHITE);
                    break;
                case ColorSchemeType.BlueGrey:
                    colorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue700,
                        TextShade.WHITE);
                    break;
                default:
                    MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                    colorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;
            }
            return colorScheme;
        }
    }
}
