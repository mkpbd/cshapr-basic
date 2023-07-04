using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Interfaces
{
    public interface IGenericEnumerator<T> : IEnumerator, IDisposable
    {
        T Current { get; }
    }
}