using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static System.Diagnostics.Activity;

namespace Collection.Interfaces
{
    public class ListOwn<T> : IList<T>, IReadOnlyList<T>
    {

        public ListOwn() { }
        public ListOwn(IEnumerable<T> collection) { }
        public ListOwn(int capacity) { }

        // Add+Insert
        public void Add(T item) { }
        public void AddRange(IEnumerable<T> collection) { }
        public void Insert(int index, T item) { }
        public void InsertRange(int index, IEnumerable<T> collection) { }
        // Remove
        public bool Remove(T item) { return true; }
        public void RemoveAt(int index) { }
        public T this[int index] => throw new NotImplementedException();

        public void RemoveRange(int index, int count) { }
        public int RemoveAll(Predicate<T> match) { return 0; }

        // Indexing
        // public T this[int index] { get; set; }
        public List<T> GetRange(int index, int count)
        {
            throw new NotSupportedException();
        }
        public Enumerator<T> GetEnumerator()
        {
            throw new NotSupportedException();
        }
        // Exporting, copying and converting:
        public T[] ToArray() { return null; }
        public void CopyTo(T[] array) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
        // public ReadOnlyCollection<T> AsReadOnly(){ 
        //     throw new  NotImplementedException();
        // }
        public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        {
            throw new NotImplementedException();
        }
        // Other:
        public void Reverse() { }// Reverses order of elements in list.
        public int Capacity { get; set; } // Forces expansion of internal array.
        public void TrimExcess() { } // Trims internal array back to size.
        public void Clear() { } // Removes all elements, so Count=0.

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();


    }







}
