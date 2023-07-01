using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingTypes.Interfaces
{
    public interface IEquatables<T>
    {
        bool Equals(T obj);
    }
}