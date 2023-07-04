using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class Enumerators : IEnumerator
    {
        MyIntList collection;
        int currentIndex = -1;
        public Enumerators(MyIntList items) => this.collection = items;
        public object Current
        {
            get
            {
                if (currentIndex == -1)
                    throw new InvalidOperationException("Enumeration not started!");
                if (currentIndex == collection.data.Length)
                    throw new InvalidOperationException("Past end of list!");
                return collection.data[currentIndex];
            }
        }
        public bool MoveNext()
        {
            if (currentIndex >= collection.data.Length - 1) return false;
            return ++currentIndex < collection.data.Length;
        }
        public void Reset() => currentIndex = -1;
    }
}
