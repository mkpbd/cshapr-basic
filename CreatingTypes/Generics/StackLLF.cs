using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingTypes.Generics
{
    public class StackLLF<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }
}