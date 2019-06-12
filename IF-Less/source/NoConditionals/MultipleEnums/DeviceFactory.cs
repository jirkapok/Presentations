namespace NoConditionals.MultipleEnums
{
    internal class DeviceFactory
    {
        public IDevice GetDevice(DeviceFamily deviceFamily)
        {
            switch (deviceFamily)
            {
                case DeviceFamily.Hq300:
                    return new Hq300();
                case DeviceFamily.Sa700:
                    return new Sa700Device();
                default:
                    return new UnknowDevice();
            }
        }
    }
}