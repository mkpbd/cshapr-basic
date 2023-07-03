using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public record Point
    {
        public Point(double x, double y) => (X, Y) = (x, y);
        public double DistanceFromOrigin { get; }
        public double X { get; init; }
        public double Y { get; init; }

        double _x, _y;
        double? _distance;
        public double Xx { get => _x; init { _x = value; _distance = null; } }
        public double Yy { get => _y; init { _y = value; _distance = null; } }
        public double DistanceFromOriginUpdate => _distance ??= Math.Sqrt(X * X + Y * Y);
    }
}