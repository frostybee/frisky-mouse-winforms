namespace FriskyMouse.Drawing.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ConstructableEnumAttribute : Attribute
    {
        public Type Type { get; set; }
        public ConstructableEnumAttribute(Type type)
        {
            Type = type;
        }
    }
}
