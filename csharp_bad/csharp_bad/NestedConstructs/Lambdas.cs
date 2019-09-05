using System;

namespace csharp_bad.NestedConstructs
{
    public static class Lambdas
    {
        public static string Transform()
        {
            var localNumber = 45;

            // emitted as delegate class
            Func<int, string> AsPrintable = (int source) =>
            {
                // forces emit of struct which wraps local variable
                localNumber = 0;
                return source.ToString();
            };

            // state is added as parameter
            var texts = AsPrintable(localNumber);

            return texts;
        }
    }
}