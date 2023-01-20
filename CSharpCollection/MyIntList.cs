using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    public class MyIntList : IEnumerable<int>
    {
       public  int[] data = { 1, 2, 3 };
        // The generic enumerator is compatible with both IEnumerable and
        // IEnumerable<T>. We implement the nongeneric GetEnumerator method
        // explicitly to avoid a naming conflict.
        public IEnumerator<int> GetEnumerator() => new Enumerator(this);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);
    }

  public  class Enumerator : IEnumerator<int>
    {
        int currentIndex = -1;
        MyIntList items;
        MyIntList collection;
        public Enumerator(MyIntList items) => this.items = items;
        public int Current => collection.data[currentIndex];
        object IEnumerator.Current => Current;
        public bool MoveNext() => ++currentIndex < collection.data.Length;
        public void Reset() => currentIndex = -1;
        // Given we don't need a Dispose method, it's good practice to
        // implement it explicitly, so it's hidden from the public interface.
        void IDisposable.Dispose() { }
    }
}

