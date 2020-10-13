using System;
using NUnit.Framework;
using Suite;

namespace Tests
{
    public class RunningTimeTests
    {
        // execute this test multiple times to see its results
        // code smell fixed:
        // - DateTime.Now depends on time zone
        // - the test mimics the implementation 
        [Test]
        public void Always_Use_Fixed_Values()
        {
            var source = new DateTime(2000, 9, 12,14,36,41, DateTimeKind.Utc);
            var expected = "2:36:41 PM";
            var formatted = RunningTime.FormatToReport(source);
            Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}