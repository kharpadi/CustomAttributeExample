using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample
{
    public static class DateFormatControl
    {
        public static bool Validate(object obj)
        {
            var props = obj.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var prop in props)
            {
                var attributes = prop.GetCustomAttributes(typeof(DateFormatAttribute), true);
                if (attributes.Length > 0)
                {
                    var value = prop.GetValue(obj);
                    if (value is string dateString)
                    {
                        if (!DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
