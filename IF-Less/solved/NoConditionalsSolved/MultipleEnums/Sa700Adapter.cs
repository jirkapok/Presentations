namespace NoConditionalsSolved.MultipleEnums
{
    internal class Sa700Adapter : DefaultFamilyAdapter
    {
        public override int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return 2 * currentSensorValue;
        }
    }
}