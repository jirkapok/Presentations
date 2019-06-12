using System.Linq;

namespace NoConditionalsSolved.IfElseToTable
{
    internal class SensorValueToMovementConverter
    {
        private static readonly MeasureTransform[] Transformations = new MeasureTransform[]
            {
                // It depends on the order
                new MeasureTransform(m => m > 8, m => 5 * m * m - 3),
                new MeasureTransform(m => m > 4, m => 4 * m - 2),
                new MeasureTransform(m => m >= 0, m => 3 * m - 1),
                new MeasureTransform(m => true, m => 2 * m) // fallback, always has to be implemented.                                                                    
            };

        internal static int CalculateBasedOnPrecision(int measuredValue)
        {
            var executor = Transformations.First(t => t.CanApply(measuredValue));
            return executor.Transform(measuredValue);
        }
    }
}