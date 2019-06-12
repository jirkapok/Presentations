using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void FiveTwo_Add_Returns7()
        {
            var result = CalculatorService.Calculate(Commands.add, 5, 2);
            Assert.AreEqual(7, result);
        }
        
        [TestMethod]
        public void FiveTwo_Sub_Returns3()
        {
            var result = CalculatorService.Calculate(Commands.sub, 5, 2);
            Assert.AreEqual(3, result);
        }
        
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void UnknownCommand_ThrowsException()
        {
            CalculatorService.Calculate((Commands)int.MaxValue, 5, 2);
        }
    }
}
