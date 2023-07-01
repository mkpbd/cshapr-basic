using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
namespace ImplementInterface
{
    public class Countdown : IEnumeratorByOwn
    {
        int count = 11;
        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset() { throw new NotSupportedException(); }
    }
}