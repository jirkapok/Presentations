﻿using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
			int first = Convert.ToInt32(Console.ReadLine());
			int second = Convert.ToInt32(Console.ReadLine());
			var command = (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());

            int result;
            
            result = Calculate(command, first, second);

            Console.WriteLine(result);


            Console.ReadKey();
        }

        internal static int Calculate(Commands command, int first, int second)
        {
            int result;
            switch (command)
            {
                case Commands.add:
                    result = Mathematics.Add(first, second);
                    break;
                default:
                    throw new InvalidOperationException("Unknown command in calculator");
            }

            return result;
        }
    }
}
