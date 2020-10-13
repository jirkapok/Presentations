using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConditionalStatementTests
    {
        [Test]
        public void Conditionals_in_tests_do_not_make_sense()
        {
            string testString = "Any string we want to concatenate";    

            for (int iter = 0; iter < 2; iter++)
            {
                var expected = testString;

                if (iter == 0) // add at the beginning
                {
                    expected = 'b' + expected;
                    testString = testString.Insert(0, "b");
                }
                else // add at the end
                {
                    expected += 'b';
                    testString = testString.Insert(testString.Length, "b");
                }

                Assert.AreEqual(expected, testString);
            }
        }
    }
}