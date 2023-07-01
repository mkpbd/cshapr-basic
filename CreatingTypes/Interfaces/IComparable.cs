using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingTypes.Interfaces
{
    public interface IComparable<T> // Simplified version of interface
    {
        int CompareTo(T other);
    }
}