using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public class SimpleDelegate
    {
        public static int GetIndexOfFirstNonEmptyBin(int[] bins) => Array.FindIndex(bins, IsGreaterThanZero);
        private static bool IsGreaterThanZero(int value) => value > 0;
        // public static int FindIndex<T>( T[] array, Predicate<T> match){ return match(); }
    }
}