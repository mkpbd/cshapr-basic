using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class Enumeratores : IEnumerator<int>
    {
        int currentIndex = -1;
        MyIntListes items;
        MyIntListes collection;
        public Enumeratores(MyIntListes items) => this.items = items;
        public int Current => collection.data[currentIndex];
        object IEnumerator.Current => Current;

        // object System.Collections.IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext() => ++currentIndex < collection.data.Length;
        public void Reset() => currentIndex = -1;
        // Given we don't need a Dispose method, it's good practice to
        // implement it explicitly, so it's hidden from the public interface.
        void IDisposable.Dispose() { }
    }
}