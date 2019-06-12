namespace NoConditionals.MultipleEnums
{
    internal class UnknowDevice : IDevice
    {
        internal const int DefaultDeviceMultiplier = 1;

        public string GetDeviceFamilyName()
        {
            return "default";
        }

        public int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return DefaultDeviceMultiplier;
        }
    }
}