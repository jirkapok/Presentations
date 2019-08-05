using csharp_bad;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class SyntacticSugarTests
    {
        [Test]
        public void GetBackingField()
        {
            var properties = new SyntacticSugar()
            {
                PropA =  "Expected"
            };
            Assert.AreEqual(properties.PropA, properties.PropB);
        }
    }
}
