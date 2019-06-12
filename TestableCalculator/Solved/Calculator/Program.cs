using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
			int first = ReadNumber();
			int second = ReadNumber();
			var command = ReadCommand();
            var result = CalculatorService.Calculate(command, first, second);
            WriteResult(result);
        }

        private static void WriteResult(int result)
        {
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static Commands ReadCommand()
        {
            return (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
        }

        private static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
