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
            var properties = new SyntacticSugar()
            {
                PropA =  "Expected"
            };
            Assert.AreEqual(properties.PropA, properties.PropB);
        }
    }
}
