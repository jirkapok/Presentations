using System;

namespace csharp_bad
{
    public class Circle
    {
        public int Radius { get; }

        public double Area => Math.PI * Math.Pow(this.Radius, 2);

        public Circle(int radius)
        {
            Radius = radius;
        }

        public static Tuple<int, double> CircleAreaByTuple(int radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return new Tuple<int, double>(radius, area);
        }

        public static (int radius, double area) CircleAreaNew(int radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return (radius, area);
        }
    }
}