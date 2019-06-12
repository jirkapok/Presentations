namespace NoConditionalsSolved.MultipleEnums
{
    internal class DefaultFamilyAdapter : IFamilyAdapter
    {
        public virtual string GetDeviceFamilyName()
        {
            return "unknown";
        }

        public virtual int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return 1;
        }
    }
}