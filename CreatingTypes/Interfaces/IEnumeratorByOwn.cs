using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEnumeratorByOwn
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}