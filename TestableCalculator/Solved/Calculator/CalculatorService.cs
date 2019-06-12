using System;

namespace Calculator
{
    internal class CalculatorService
    {
        internal static int Calculate(Commands command, int first, int second)
        {
            switch (command)
            {
                case Commands.add:
                    return Mathematics.Add(first, second);
                default:
                    throw new InvalidOperationException("Unknown command in calculator");
            }
        }
    }
}