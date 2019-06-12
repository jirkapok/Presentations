namespace NoConditionals.MultipleEnums
{
    internal class Sa700Device : IDevice
    {
        public string GetDeviceFamilyName()
        {
            return "Sa v1.1";
        }

        public int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return 2 * currentSensorValue;
        }
    }
}