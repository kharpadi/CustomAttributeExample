using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample
{
    public static class ReqiredControl
    {
        public static bool Validate(object obj)
        {
            var props = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                var attributes = prop.GetCustomAttributes(typeof(RequiredAreaAttribute), true);
                if (attributes.Length > 0)
                {
                    var value = prop.GetValue(obj);
                    if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
