using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Extension
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }

        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
                return element;
            throw new InvalidOperationException("No elements!");
        }
    }
}