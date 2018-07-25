using System;

namespace GreenHorn.Essentials
{
    public static class Extensions
    {
        public static T ThrowIfNull<T>(this T obj, string parameterName) where T : class
        {
            if (obj == null) throw new ArgumentNullException(parameterName);
            return obj;
        }
    }
}
