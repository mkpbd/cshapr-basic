using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public class PointClass
    {
        public PointClass(double x, double y) => (X, Y) = (x, y);
        public double X { get; init; }
        public double Y { get; init; }
        protected PointClass(PointClass original) // “Copy constructor”
        {
            this.X = original.X; this.Y = original.Y
        }
        // This method has a strange compiler-generated name:
        // public virtual PointClass <Clone>$() => new PointClass (this); // Clone method
        // Additional code to override Equals, ==, !=, GetHashCode, ToString()
    }
}