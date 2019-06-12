namespace NoConditionals.MultipleEnums
{
    internal interface IDevice
    {
        string GetDeviceFamilyName();

        int CalculateDeviceMultiplier(int currentSensorValue);
    }
}