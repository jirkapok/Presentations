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
            var tuple = Circle.CircleAreaByTuple(radius);
            var custom = Circle.CircleAreaNew(radius);
            var circle = new Circle(radius);
            Assert.AreEqual(custom.area, circle.Area);
        }
    }
}