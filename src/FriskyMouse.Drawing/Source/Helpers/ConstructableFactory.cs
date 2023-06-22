using FriskyMouse.Drawing.Attributes;
using FriskyMouse.Drawing.Extensions;

namespace FriskyMouse.Drawing
{
    public class ConstructableFactory
    {

        /// <summary>
        /// Instantiates a class specified by its constructable enum value.
        /// </summary>
        /// <typeparam name="T">The actual type of the class to be instantiated.</typeparam>
        /// <param name="enumValue">The enum value that is mapped to a constructable attribute.</param>
        /// <returns>The newly created instance of the selected type.</returns>
        public static T GetInstanceOf<T>(Enum enumValue) where T : class
        {
            ConstructableEnumAttribute attribute = enumValue.GetEnumAttribute<ConstructableEnumAttribute>();            
            Type baseType = attribute.Type;
            // The type to be instantiated has to be a class that implements the IConstructable interface.
            if (baseType.IsClass && baseType.GetInterface(nameof(IConstructable)) != null)
            {
                T newInstance = (T)Activator.CreateInstance(attribute.Type);
                return newInstance;
            }
            
            return null;
        }        
    }
}
