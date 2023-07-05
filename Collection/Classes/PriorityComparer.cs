using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class PriorityComparer : Comparer<Wish>
    {
        public override int Compare(Wish x, Wish y)
        {
            if (object.Equals(x, y)) return 0; // Optimization
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Priority.CompareTo(y.Priority);
        }
    }
}