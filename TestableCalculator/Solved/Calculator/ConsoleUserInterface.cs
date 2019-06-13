using System;

namespace Calculator
{
    internal class ConsoleUserInterface
    {
        internal void WriteResult(int result)
        {
            Console.WriteLine(result);
            Console.ReadKey();
        }

        internal Commands ReadCommand()
        {
            return (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
        }

        internal int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}