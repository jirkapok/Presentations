namespace NoConditionals.IfElseToTable
{
    internal static class SensorValueToMovementConverter
    {
        internal static int CalculateBasedOnPrecision(int measuredValue)
        {
            // TODO 2. Get rid of all IF statements.
            if (measuredValue > 8)
                return 5 * measuredValue * measuredValue - 3;
            
            if (measuredValue > 4)
                return 4 * measuredValue - 2;

            if (measuredValue >= 0)
                return 3 * measuredValue - 1;

            return 2 * measuredValue;
        }
    }
}