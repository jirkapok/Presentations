using System;

namespace csharp_bad.NestedConstructs
{
    // to view emitted IL code:
    // c:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\ildasm.exe
    // or Resharper Windows > IL Viewer
    public static class LocalFunctions
    {
        public static string Transform()
        {
            var localNumber = 45;

            // emitted as static method anyway
            // makes Transform method harder to read
            // usually show wrong design
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