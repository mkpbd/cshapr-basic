using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Activity;

namespace CSharpCollection
{
    public class List<T> : IList<T>, IReadOnlyList<T>
    {
        //public List();
        //public List(IEnumerable<T> collection);
        //public List(int capacity);
        // Add+Insert
        //public void Add(T item);
        //public void AddRange(IEnumerable<T> collection);
        //public void Insert(int index, T item);
        //public void InsertRange(int index, IEnumerable<T> collection);
        // Remove
        //public bool Remove(T item);
        //public void RemoveAt(int index);
        //public void RemoveRange(int index, int count);
        //public int RemoveAll(Predicate<T> match);
        // Indexing
        //public T this[int index] { get; set; }
        //public List<T> GetRange(int index, int count);
        //public Enumerator<T> GetEnumerator();
        // Exporting, copying and converting:
        //public T[] ToArray();
        //public void CopyTo(T[] array);
        //public void CopyTo(T[] array, int arrayIndex);
        //public void CopyTo(int index, T[] array, int arrayIndex, int count);
        //public ReadOnlyCollection<T> AsReadOnly();
        //public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput>
        //converter);
        // Other:
        //public void Reverse(); // Reverses order of elements in list.
        //public int Capacity { get; set; } // Forces expansion of internal array.

        //public int Count => throw new NotImplementedException();

        //public bool IsReadOnly => throw new NotImplementedException();

        //public void TrimExcess(); // Trims internal array back to size.
        //public void Clear(); // Removes all elements, so Count=0.

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
    }
}
