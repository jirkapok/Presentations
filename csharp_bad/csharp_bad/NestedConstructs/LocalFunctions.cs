using System;

namespace csharp_bad.NestedConstructs
{
    public static class LocalFunctions
    {
        public static string Transform()
        {
            var localNumber = 45;

            // emitted as static method
            string AsPrintable(int source)
            {
                // forces emit of struct which wraps local variable
                localNumber = 0;
                return source.ToString();
            }

            // state is added as another parameter called by reference
            var texts = AsPrintable(localNumber);

            return texts;
        }
    }
}