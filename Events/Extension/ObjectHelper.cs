using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Extension
{
    public static class ObjectHelper
    {
        public static bool IsCapitalized(this object s)
        {
            if (s == null) return false;

            var r = s.ToString();
            // return  r[0].ToString().ToUpper();

            return true;
        }
    }
}