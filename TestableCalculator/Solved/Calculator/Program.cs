using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
            var ui = new ConsoleUserInterface();
            new CalculatorService(ui)
                .Calculate();
        }
    }
}
