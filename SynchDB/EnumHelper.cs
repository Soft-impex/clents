using System;

namespace SynchDB
{
    public static class EnumHelper
    {
        public static T GetEnumValue<T>(string str) where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new Exception("T must be an Enumeration type.");
            }
            T val;
            if (Enum.TryParse<T>(str, true, out val))
                return val;
            else
            {
                foreach (Enum e in Enum.GetValues(typeof(T)))
                    if (((Enum)e).Description() == str)
                        return (T)Convert.ChangeType(e, typeof(T));
            }
            return default(T);
            //return Enum.TryParse<T>(str, true, out val) ? val : default(T);
        }

        public static T GetEnumValue<T>(int intValue) where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new Exception("T must be an Enumeration type.");
            }

            return (T)Enum.ToObject(enumType, intValue);
        }
    }
}
