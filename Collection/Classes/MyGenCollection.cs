using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class MyGenCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
                yield return i;
        }
        // Explicit implementation keeps it hidden:
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public static IEnumerable<int> GetSomeIntegers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}