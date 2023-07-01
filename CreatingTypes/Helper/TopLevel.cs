using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingTypes.Helper
{
    public class TopLevel
    {
        static int x;
        class Nested
        {
            static void Foo() { Console.WriteLine(TopLevel.x); }
        }
    }
}