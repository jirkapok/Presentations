using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
            var ui = new ConsoleUserInterface();
            Calculate(ui);
        }

        internal static void Calculate(IUserInterface ui)
        {
            int first = ui.ReadNumber();
            int second = ui.ReadNumber();
            var command = ui.ReadCommand();
            var result = CalculatorService.Calculate(command, first, second);
            ui.WriteResult(result);
        }
    }
}
