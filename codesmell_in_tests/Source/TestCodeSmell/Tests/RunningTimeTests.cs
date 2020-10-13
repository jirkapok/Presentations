using System;
using NUnit.Framework;
using Suite;

namespace Tests
{
    public class RunningTimeTests
    {
        // execute this test multiple times to see its results
        // code smell:
        // - DateTime.Now depends on time zone
        // - the test mimics the implementation 
        [Test]
        public void Always_Use_Fixed_Values()
        {
            var source = DateTime.Now;
            var expected = source.ToShortTimeString();
            var formatted = RunningTime.FormatToReport(source);
            Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}