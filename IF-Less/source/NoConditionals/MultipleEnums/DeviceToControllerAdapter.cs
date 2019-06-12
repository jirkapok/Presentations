namespace NoConditionals.MultipleEnums
{
    internal class DeviceToControllerAdapter
    {
        private readonly DeviceFamily device;

        public DeviceToControllerAdapter(DeviceFamily device)
        {
            this.device = device;
        }

        public string GetDeviceFamilyName()
        {
            // TODO 1. Merge both switch statements in this class into one.
            switch (this.device)
            {
                case DeviceFamily.Hq300:
                    return "Hq v2";
                case DeviceFamily.Sa700:
                    return "Sa v1.1";
                default:
                    return null;
            }
        }

        public int CalculateDeviceMultiplier(int currentSensorValue)
        {
            switch (this.device)
            {
                case DeviceFamily.Sa700:
                    return 2 * currentSensorValue;
                default:
                    return 1;
            }
        }
    }
}
