using System;

namespace Suite
{
    public static class RunningTime
    {
        public static string FormatToReport(DateTime toConvert)
        {
            return toConvert.ToLongTimeString();
        }
    }
}
