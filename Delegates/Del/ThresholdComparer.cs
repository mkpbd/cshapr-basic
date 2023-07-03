using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates.Del
{
    public class ThresholdComparer
    {
        public int Threshold { get; set; }
        public bool IsGreaterThan(int value) => value > Threshold;
        public PredicateDel<int> GetIsGreaterThanPredicate() => IsGreaterThan;
    }
}