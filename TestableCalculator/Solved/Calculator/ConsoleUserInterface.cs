using System;

namespace Calculator
{
    internal class ConsoleUserInterface : IUserInterface
    {
        public void WriteResult(int result)
        {
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public Commands ReadCommand()
        {
            return (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
        }

        public int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}