using NUnit.Framework;
using System;
using FluentAssertions;
using NUnit.Framework.Interfaces;

namespace Tests
{
    [TestFixture]
    public class MultipleAssertTests
    {
        // code smell fixed:
        // - custom assert method has lot of arguments
        // - when first assert fails we don't know the results of following asserts, solved tricky by assert message
        // - useless assert message
        [Test]
        public static void Ctor_Long_DateTimeKind()
        {
            var sut = new DateTime(999999999999999999, DateTimeKind.Utc);

            // cast ot object to avoid implicit DateTime comparison for test purposes
            // compare the error message with original code
            ((object)sut).Should().BeEquivalentTo(
            new {
                Year = 3169,
                Month = 11,
                Day = 16,
                Hour = 19,
                Minute = 46,
                Seconds = 39,
                Millisecond = 999,
                Kind = DateTimeKind.Utc
            });
        }
    }
}