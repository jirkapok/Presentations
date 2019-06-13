using System;

namespace Calculator
{
    internal class CalculatorService
    {
        private readonly IUserInterface ui;

        public CalculatorService(IUserInterface ui)
        {
            this.ui = ui;
        }

        internal void Calculate()
        {
            int first = this.ui.ReadNumber();
            int second = this.ui.ReadNumber();
            var command = this.ui.ReadCommand();
            var result = Calculate(command, first, second);
            this.ui.WriteResult(result);
        }

        private static int Calculate(Commands command, int first, int second)
        {
            switch (command)
            {
                case Commands.add:
                    return Mathematics.Add(first, second);
                case Commands.sub:
                    return Mathematics.Sub(first, second);
                default:
                    throw new InvalidOperationException("Unknown command in calculator");
            }
        }
    }
}