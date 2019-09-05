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
    }
}