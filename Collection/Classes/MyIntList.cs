using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collection.Classes;

namespace Collection.Classes
{
    public class MyIntList : IEnumerable
    {
        public int[] data = { 1, 2, 3 };
        public IEnumerator GetEnumerator() => new Enumerators(this);
    }
}