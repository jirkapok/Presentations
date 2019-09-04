using System.Globalization;

namespace csharp_bad
{
    public static class StringInterpolation
    {
        public static string Format(long money)
        {
            var backup = CultureInfo.CurrentCulture;
            var czech = CultureInfo.GetCultureInfo("cs-CZ");
            CultureInfo.CurrentCulture = czech;
            var formatted = $"{money:N}";
            CultureInfo.CurrentCulture = backup;
            return formatted;
        }
    }
}