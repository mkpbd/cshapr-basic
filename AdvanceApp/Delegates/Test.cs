using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public delegate bool Predicates<in T>(T obj);
    public class Test
    {
        public static int Square(int x) => x * x;
        public static int Cube(int x) => x * x * x;
    }
}