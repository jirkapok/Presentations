using csharp_bad;
using csharp_bad.Exceptions;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class ExceptionFiltersTests
    {
        [Test]
        public void Wrong_Usage_Of_Filter()
        {
            // Filters shouldn't be used for code branching
            var result = ExceptionFilters.Fail(10);
            Assert.AreEqual("NotEnoughSpace", result);
        }
    }
}