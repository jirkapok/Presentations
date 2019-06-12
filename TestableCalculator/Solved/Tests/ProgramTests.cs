using System;
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
            var result = Program.Calculate(Commands.add, 5, 2);
            Assert.AreEqual(7, result);
        }
        
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void UnknownCommand_ThrowsException()
        {
            Program.Calculate((Commands)int.MaxValue, 5, 2);
        }
    }
}
