using NoConditionals;

namespace NoConditionalsSolved.MultipleEnums
{
    internal class DeviceToControllerAdapter
    {
        private readonly IFamilyAdapter device;

        public DeviceToControllerAdapter(DeviceFamily device)
        {
            this.device = SelectByDeviceType(device);
        }

        private static IFamilyAdapter SelectByDeviceType(DeviceFamily deviceFamily)
        {
            switch (deviceFamily)
            {
                case DeviceFamily.Hq300:
                    return new Hq300Adapter();
                case DeviceFamily.Sa700:
                    return new Sa700Adapter();
                default:
                    return new DefaultFamilyAdapter();
            }
        }

        public string GetDeviceFamilyName()
        {
            return this.device.GetDeviceFamilyName();
        }

        public int CalculateDeviceMultiplier(int currentSensorValue)
        {
            return this.device.CalculateDeviceMultiplier(currentSensorValue);
        }
    }
}
