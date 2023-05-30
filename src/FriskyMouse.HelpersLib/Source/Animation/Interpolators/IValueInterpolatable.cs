namespace FriskyMouse.HelpersLib.Animation
{
    public interface IValueInterpolatable: IConstructable
    {
        double Interpolate(double value);
    }
}
