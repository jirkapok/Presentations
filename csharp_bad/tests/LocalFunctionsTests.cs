using System;
using System.Linq;
using csharp_bad.NestedConstructs;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class LocalFunctionsTests
    {
        [Test]
        public void Local_functions_parameters_are_called_by_reference()
        {
            var transformed = LocalFunctions.Transform();
            var transformed2 = Lambdas.Transform();
            Assert.AreEqual(transformed2, transformed);
        }

        // Compare behavior of the two following methods
        [Test]
        public void Exception_is_thrown_in_Transform()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var transformed = EnumerableLocalFunctions.Transform(null);
                var result = transformed.ToList(); // remove to see the difference
            });
        }

        [Test]
        public void Exception_is_thrown_in_TransformDirectly()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var transformed = EnumerableLocalFunctions.TransformDirectly(null);
                var result = transformed.ToList(); // remove to see the difference
            });
        }
    }
}