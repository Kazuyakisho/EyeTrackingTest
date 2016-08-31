using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EyeTrackingMouseV03Lib.Utils
{
    public static class ReflectionSearch
    {
        public static IEnumerable<Type> GetDerivedTypes(this Type baseType, Assembly assembly)
        {
            var types = from t in assembly.GetTypes()
                where t.IsSubclassOf(baseType)
                select t;

            return types;
        }
    }
}
