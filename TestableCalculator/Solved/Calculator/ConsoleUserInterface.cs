using System;

namespace Calculator
{
    internal class ConsoleUserInterface
    {
        internal static void WriteResult(int result)
        {
            Console.WriteLine(result);
            Console.ReadKey();
        }

        internal static Commands ReadCommand()
        {
            return (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
        }

        internal static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}