using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConditionalStatementTests
    {
        // code smell fixed: IF statement in test, or boolean parameter in helper method

        private const string testString = "Any string we want to concatenate";

        [Test]
        public void Insert_to_beginning()
        {
            var expected = 'b' + testString;
            var actual = testString.Insert(0, "b");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Insert_to_the_End()
        {
            var expected = testString + 'b';
            var actual = testString.Insert(testString.Length, "b");
            Assert.AreEqual(expected, actual);
        }
    }
}