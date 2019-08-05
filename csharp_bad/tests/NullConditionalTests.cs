using csharp_bad;
using FluentAssertions;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class NullConditionalTests
    {
        [Test]
        public void NullProperty_ReturnsNull_But_Hides_DataType()
        {
            var member = new NullConditional();
            var charCount = member.Dummy?.Count;
            // What is the type of charCount?

            Assert.AreNotEqual(0, charCount);
        }

        [Test]
        public void NullProperty_StopsExecution()
        {
            var member = new NullConditional();
            var expected = "expected";
            member.Dummy?.Insert(0,expected);

            // The should method isn't executed
            member.Dummy?.Should().Contain(expected);
        }
    }
}