using System.Globalization;
using csharp_bad;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class StringInterpolationTests
    {
        [Test]
        public void Format_Is_CultureSensitive()
        {
            // Shorter syntax is harder to read.
            // $ hides internationalization and has no overload for it.
            var money = 2600;
            var result = StringInterpolation.Format(money); // implemented as $"{money:N}";
            var expected = string.Format(CultureInfo.CurrentCulture, "{0:N}", money);
            Assert.AreNotEqual(expected, result);
        }
    }
}