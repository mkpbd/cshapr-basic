using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    public interface ICollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool IsReadOnly { get; }
        void Add(T item);
        bool Remove(T item);
        void Clear();
    
    
    }

    public interface ICollection : IEnumerable
    {
        int Count { get; }
        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(Array array, int index);
    }
}
