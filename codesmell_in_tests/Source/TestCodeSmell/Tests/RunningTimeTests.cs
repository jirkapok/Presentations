using System;
using NUnit.Framework;
using Suite;

namespace Tests
{
    public class RunningTimeTests
    {
        [Test]
        public void Always_Use_Fixed_Values()
        {
            // execute this test multiple times to see its results
            // there are two mistakes: DateTime.Now depends on time zone and the test mimics the implementation 
            var source = DateTime.Now;
            var expected = source.ToShortTimeString();
            var formatted = RunningTime.FormatToReport(source);
            Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}