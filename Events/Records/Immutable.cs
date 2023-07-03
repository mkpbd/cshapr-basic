using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public struct Mutable { public int X, Y; }
    public class Immutable
    {
        public readonly Mutable Field;
        public Mutable Prop { get; }
    }
}