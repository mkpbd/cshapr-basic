using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Extension
{
    public class Test
    {
        public void Foo(object x) { } // This method always wins

        public (string name, int age, string Address) GetFullAddress(string address)
        {

            return ("kamal", 22, "Gaziput");
        }

    }
    public static class Extensions
    {
        public static void Foo(this Test t, int x)
        {

            t.Foo(x);
        }

    }
}