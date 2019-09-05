using System;
using System.Collections.Generic;

namespace csharp_bad.NestedConstructs
{
    public static class EnumerableLocalFunctions
    {
        public static IEnumerable<string> Transform(int[] numbers)
        {
            // when the exception is thrown?
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