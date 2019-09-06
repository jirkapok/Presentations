using System;
using csharp_bad;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class TuplesTests
    {
        [Test]
        public void Tuples_Shouldnt_be_objects_replacement()
        {
            var radius = 5;
            Tuple<int, double> tuple = Circle.CircleAreaByTuple(radius);
            (int radius, double area) custom = Circle.CircleAreaNew(radius);
            var circle = new Circle(radius);
            Assert.AreEqual(custom.area, circle.Area);
        }
    }
}