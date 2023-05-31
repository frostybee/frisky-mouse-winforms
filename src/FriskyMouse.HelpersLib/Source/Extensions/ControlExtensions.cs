using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FriskyMouse.HelpersLib.Extensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Populates a combobox control with the description and values parsed from 
        /// the supplied Enum definition. 
        /// </summary>
        /// <param name="inComboBox">The combobox control to be populated. </param>
        /// <param name="inEnumType">The type of the enum that contains 
        /// the definitions of values along with their description attributes. </param>
        public static void PopulateFromEnum(this ComboBox inComboBox, Type inEnumType)
        {
            inComboBox.DataSource = Enum.GetValues(inEnumType)
             .Cast<Enum>()
             .Select(value => new
             {
                 (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                 typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                 value
             })
            .OrderBy(item => item.value)
            .ToList();
            inComboBox.DisplayMember = "Description";
            inComboBox.ValueMember = "value";
        }

        /// <summary>
        /// Returns the enum value based on the selected string in the supplied combobox control.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum of which the value should be returned.</typeparam>
        /// <param name="inComboBox">The combobox control that contains the selected value.</param>
        /// <returns></returns>
        public static TEnum ParseEnumValue<TEnum>(this ComboBox inComboBox) where TEnum : struct
        {
            return Enum.TryParse<TEnum>(inComboBox.SelectedValue.ToString(), out var result)
                ? result
                : default;
        }
    }
}
