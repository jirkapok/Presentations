namespace NoConditionals.MultipleEnums
{
    internal class Hq300 : IDevice
    {
        public string GetDeviceFamilyName()
        {
            return "Hq v2";
        }

        public int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return UnknowDevice.DefaultDeviceMultiplier;
        }
    }
}