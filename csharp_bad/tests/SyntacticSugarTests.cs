using csharp_bad;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class SyntacticSugarTests
    {
        [Test]
        public void Multiple_Ways_For_Property_Large_Learning_Curve()
        {
            // See multiple ways how to define property which makes the beginner hard to read
            var properties = new SyntacticSugar()
            {
                PropA =  "Expected"
            };

            Assert.AreEqual(properties.PropA, properties.PropB);
        }

        [Test]
        public void Type_Contains_Hidden_Methods()
        {
            // all cenvert to get/set accessors anyway
            var properties = new SyntacticSugar();

            var type = properties.GetType();
            var methods = type.GetMethods();
            var getter_method = type.GetMethod("get_PropA");
            Assert.IsNotNull(getter_method);
        }
    }
}
