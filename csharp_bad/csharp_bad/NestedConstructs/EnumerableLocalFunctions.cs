using System;
using System.Collections.Generic;

namespace csharp_bad.NestedConstructs
{
    public static class EnumerableLocalFunctions
    {
        public static IEnumerable<string> Transform(int[] numbers)
        {
            // when the exception is thrown?
            // ArgumentNullException is used only for simulation, imagine reference null exception in large code base
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            IEnumerable<string> AsPrintable(int[] source)
            {
                foreach (var number in numbers)
                {
                    yield return number.ToString();
                }
            }

            return AsPrintable(numbers);
        }

        // the same behavior when using lambda
        public static IEnumerable<string> TransformDirectly(int[] numbers)
        {
            // when the exception is thrown?
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            foreach (var number in numbers)
            {
                yield return number.ToString();
            }
        }
    }
}