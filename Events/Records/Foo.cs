using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public record Foo
    {
        public Foo(int required1, int required2)
        {

        }
        public int Required1 { get; init; }
        public int Required2 { get; init; }
        public int Optional1 { get; init; }
        public int Optional2 { get; init; }
    }
}