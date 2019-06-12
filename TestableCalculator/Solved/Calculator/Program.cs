using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
			int first = ConsoleUserInterface.ReadNumber();
			int second = ConsoleUserInterface.ReadNumber();
			var command = ConsoleUserInterface.ReadCommand();
            var result = CalculatorService.Calculate(command, first, second);
            ConsoleUserInterface.WriteResult(result);
        }
    }
}
