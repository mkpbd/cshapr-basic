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

        public void TransformDelegate(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }

        }
    }
}