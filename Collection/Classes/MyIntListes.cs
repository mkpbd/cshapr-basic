using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class MyIntListes : IEnumerable<int>
    {
        public int[] data = { 1, 2, 3 };
        // The generic enumerator is compatible with both IEnumerable and
        // IEnumerable<T>. We implement the nongeneric GetEnumerator method
        // explicitly to avoid a naming conflict.
        public IEnumerator<int> GetEnumerator() => new Enumeratores(this);
        IEnumerator IEnumerable.GetEnumerator() => new Enumeratores(this);


    }
}