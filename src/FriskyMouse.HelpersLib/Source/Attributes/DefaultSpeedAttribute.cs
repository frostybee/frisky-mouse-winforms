using System;

namespace FriskyMouse.HelpersLib.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class DefaultSpeedAttribute : Attribute
    {
        public int Speed { get; set; }
        public DefaultSpeedAttribute(int pSpeed) {
            Speed = pSpeed;
        }
    }
}
