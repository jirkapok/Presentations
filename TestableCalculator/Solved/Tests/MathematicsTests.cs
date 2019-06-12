using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MathematicsTests
    {
        [TestMethod]
        public void FiveTwo_Add_Returns7()
        {
            var result = Mathematics.Add(5, 2);
            Assert.AreEqual(7, result);
        }
    }
}
