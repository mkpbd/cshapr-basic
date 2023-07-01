using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreatingTypes.Interfaces;

namespace CreatingTypes.Generics
{
    public class Balloon : IEquatables<Balloon>
    {
        public string Color { get; set; }
        public int CC { get; set; }
        public bool Equals(Balloon b)
        {
            if (b == null) return false;
            return b.Color == Color && b.CC == CC;
        }
    }
}