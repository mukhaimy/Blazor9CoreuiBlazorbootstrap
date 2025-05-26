using System;
using System.Reflection;

namespace Blazor9CoreuiBlazorbootstrap.Helpers
{
    public class ObjectCopy
    {
        public static void CopyValues<T>(T source, T target)
        {
            if (source == null || target == null) throw new ArgumentNullException();

            Type type = typeof(T);
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.CanRead && property.CanWrite)
                {
                    var value = property.GetValue(source);
                    property.SetValue(target, value);
                }
            }
        }

    }
}
