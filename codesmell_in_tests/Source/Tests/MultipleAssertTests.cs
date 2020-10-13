using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class MultipleAssertTests
    {
        // code smell:
        // - custom assert method has lot of arguments
        // - when first assert fails we don't know the results of following asserts, solved tricky by assert message
        // - useless assert message
        [Test]
        public static void Ctor_Long_DateTimeKind()
        {
            var sut = new DateTime(999999999999999999, DateTimeKind.Utc);
            VerifyDateTime(sut, 3169, 11, 16, 19, 46, 39, 999, DateTimeKind.Utc);
        }

        private static void VerifyDateTime(DateTime dateTime, int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
        {
            Assert.That(year, Is.EqualTo(dateTime.Year), "#1");
            Assert.That(month, Is.EqualTo(dateTime.Month), "#2");
            Assert.That(day, Is.EqualTo(dateTime.Day), "#3");
            Assert.That(hour, Is.EqualTo(dateTime.Hour), "#4");
            Assert.That(minute, Is.EqualTo(dateTime.Minute), "#5");
            Assert.That(second, Is.EqualTo(dateTime.Second), "#6");
            Assert.That(millisecond, Is.EqualTo(dateTime.Millisecond), "#7");

            Assert.That(kind, Is.EqualTo(dateTime.Kind));
        }
    }
}