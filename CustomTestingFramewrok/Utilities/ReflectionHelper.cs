using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomTestingFramework.Utilities
{
   public static class ReflectionHelper
    {
        public static bool HasAttribute<T>(this MemberInfo mi)
            where T : Attribute
        {
            var hasAttribute = mi.GetCustomAttribute<T>() != null;

            return hasAttribute;
        }
    }
}
