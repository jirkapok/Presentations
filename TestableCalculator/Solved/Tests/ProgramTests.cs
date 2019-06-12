using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FiveTwo_Add_Returns7()
        {
            var result = Program.Add(5, 2);
            Assert.AreEqual(7, result);
        }
    }
}
