using System.ComponentModel;
using System.Globalization;

namespace FriskyMouse.Helpers
{
    public static class Extensions
    {
        public static void ApplyDefaultPropertyValues(this object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                if (prop.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute attr)
                {
                    prop.SetValue(self, attr.Value);
                }
            }
        }
        public static Version Normalize(this Version version)
        {
            return new Version(Math.Max(version.Major, 0), Math.Max(version.Minor, 0), Math.Max(version.Build, 0), Math.Max(version.Revision, 0));
        }
        public static int WeekOfYear(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}