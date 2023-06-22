using System.ComponentModel;

namespace FriskyMouse.Drawing.Extensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Populates a combobox control with the description and values parsed from 
        /// the supplied Enum definition. 
        /// </summary>
        /// <param name="comboBox">The combobox control to be populated. </param>
        /// <param name="inEnumType">The type of the enum that contains 
        /// the definitions of values along with their description attributes. </param>
        public static void PopulateFromEnum<T>(this ComboBox comboBox)
        {
            comboBox.DataSource = Enum.GetValues(typeof(T))
             .Cast<Enum>()
             .Select(value => new
             {
                 (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                 typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                 value
             })
            .OrderBy(item => item.value)
            .ToList();
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "value";
        }

        public static int GetItemIndexByEumValue(this ComboBox comboBox, Enum enumValue)
        {
            int index = 0;
            DescriptionAttribute description = enumValue.GetEnumAttribute<DescriptionAttribute>();
            //-- Find the index by enum description.
            index = comboBox.FindStringExact(description.Description);
            return (index == -1 ? 0 : index);                    
        }

        /// <summary>
        /// Returns the enum value based on the selected string in the supplied combobox control.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum of which the value should be returned.</typeparam>
        /// <param name="comboBox">The combobox control that contains the selected value.</param>
        /// <returns></returns>
        public static TEnum GetEnumValue<TEnum>(this ComboBox comboBox) where TEnum : struct
        {
            return Enum.TryParse<TEnum>(comboBox.SelectedValue.ToString(), out var result)
                ? result
                : default;
        }
    }
}
