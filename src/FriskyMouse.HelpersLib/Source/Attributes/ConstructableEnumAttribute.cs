using System;

namespace FriskyMouse.HelpersLib.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ConstructableEnumAttribute : Attribute
    {
        public Type Type { get; set; }
        public ConstructableEnumAttribute(Type inType)
        {
            Type = inType;
        }
    }
}
