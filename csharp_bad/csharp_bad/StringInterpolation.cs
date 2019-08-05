using System.Globalization;

namespace csharp_bad
{
    public static class StringInterpolation
    {
        public static string Format(long money)
        {
            var backup = CultureInfo.CurrentUICulture;
            var czech = CultureInfo.GetCultureInfo("cs-CZ");
            CultureInfo.CurrentCulture = czech;
            var formatted = $"{money:N}";
            CultureInfo.CurrentUICulture = backup;
            return formatted;
        }
    }
}