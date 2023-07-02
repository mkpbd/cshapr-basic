using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public class ThresholdComparer
    {
        public int Threshold { get; set; }
        public bool IsGreaterThan(int value) => value > Threshold;
        public Predicate<int> GetIsGreaterThanPredicate() => IsGreaterThan;
        public static void CallMeRightBack(Predicates<int> userCallback)
        {
            bool result = userCallback(42);
            Console.WriteLine(result);
        }
        public static bool IsLongString(object o)
        {
            return o is string s && s.Length > 20;
        }
        public static int GetIndexOfFirstNonEmptyBin(int[] bins)
        {
            return Array.FindIndex(
            bins,
            delegate (int value) { return value > 0; }
            );
        }
    }
}