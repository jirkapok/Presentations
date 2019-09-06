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

        [Test]
        public void Exception_filters_dont_unwind_the_stack()
        {
            var unwind = ExceptionFilters.ReportFailed(10);
            var notUnwind = ExceptionFilters.ReportFailed(0);
            Assert.AreNotEqual(unwind, notUnwind);
        }
    }
}