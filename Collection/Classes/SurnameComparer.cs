using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class SurnameComparer : Comparer<string>
    {
        string Normalize(string s)
        {
            s = s.Trim().ToUpper();
            if (s.StartsWith("MC")) s = "MAC" + s.Substring(2);
            return s;
        }
        public override int Compare(string x, string y)
        => Normalize(x).CompareTo(Normalize(y));
    }
}