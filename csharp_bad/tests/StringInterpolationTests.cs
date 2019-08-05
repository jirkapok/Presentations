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
            var money = 2600;
            var result = StringInterpolation.Format(money); // $"{money:N}";
            var expected = string.Format(CultureInfo.CurrentUICulture, "{0:N}", money);
            Assert.AreNotEqual(expected, result);
        }
    }
}