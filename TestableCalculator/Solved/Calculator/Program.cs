using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
			int first = Convert.ToInt32(Console.ReadLine());
			int second = Convert.ToInt32(Console.ReadLine());
			var command = (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
            var result = CalculatorService.Calculate(command, first, second);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
