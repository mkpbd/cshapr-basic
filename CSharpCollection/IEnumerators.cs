using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    public interface IEnumerators
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }

    //public interface IEnumerable
    //{
    //    IEnumerator GetEnumerator();
    //}


    //public interface IEnumerator<T> : IEnumerator, IDisposable
    //{
    //    T Current { get; }
    //}
    //public interface IEnumerable<T> : IEnumerable
    //{
    //    IEnumerator<T> GetEnumerator();
    //}
}
