using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Interfaces
{
    public interface IEnumerableOwn
    {
        public IEnumeratorOwn GetEnumerator();
    }
}