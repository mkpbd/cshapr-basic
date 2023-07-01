using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public delegate int Transformer(int x); // Delegate type declaration
    public class Transform
    {
        public int Square(int x)
        {
            return x * x;
        }
        public int Square1(int x) => x * x;
    }
}