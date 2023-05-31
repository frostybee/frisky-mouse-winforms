using System;

namespace FriskyMouse.HelpersLib.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DefaultSpeedAttribute : Attribute
    {
        public int Speed { get; set; }
        public DefaultSpeedAttribute(int pSpeed) {
            Speed = pSpeed;
        }
    }
}
