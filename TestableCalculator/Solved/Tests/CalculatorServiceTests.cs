using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void FiveTwo_Add_Returns7()
        {
            var mockUi = new Mock<IUserInterface>();
            mockUi.SetupSequence(ui => ui.ReadNumber())
                .Returns(5)
                .Returns(2);
            mockUi.Setup(ui => ui.ReadCommand())
                .Returns(Commands.add);

            new CalculatorService(mockUi.Object).Calculate();
            mockUi.Verify(ui => ui.WriteResult(7));
        }

        [TestMethod]
        public void FiveTwo_Sub_Returns3()
        {
            var mockUi = new Mock<IUserInterface>();
            mockUi.SetupSequence(ui => ui.ReadNumber())
                .Returns(5)
                .Returns(2);
            mockUi.Setup(ui => ui.ReadCommand())
                .Returns(Commands.sub);

            new CalculatorService(mockUi.Object).Calculate();
            mockUi.Verify(ui => ui.WriteResult(3));
        }


        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void UnknownCommand_ThrowsException()
        {
            var mockUi = new Mock<IUserInterface>();
            mockUi.SetupSequence(ui => ui.ReadNumber())
                .Returns(5)
                .Returns(2);
            mockUi.Setup(ui => ui.ReadCommand())
                .Returns((Commands)int.MaxValue);

            new CalculatorService(mockUi.Object).Calculate();
        }
    }
}