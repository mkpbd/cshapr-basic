using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Lamda
{
    public class LamdaExpression
    {
        public static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++; // Returns a closure
        }

        public Func<int, int> multiplier = static n => n * 2;

        public void Foo()
        {
            int factor = 123;
            static int Multiply(int x) => x * 2; // Local static method
        }
    }
}