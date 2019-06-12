namespace NoConditionalsSolved.MultipleEnums
{
    internal interface IFamilyAdapter
    {
        string GetDeviceFamilyName();

        int CalculateDeviceMultiplier(int currentSensorValue);
    }
}