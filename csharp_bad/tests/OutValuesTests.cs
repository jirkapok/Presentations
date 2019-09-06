using csharp_bad.OutVariables;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class OutValuesTests
    {
        [Test]
        public void Out_Variables_show_new_types()
        {
            var passed = Storage.Store(5, out string error);
            Assert.IsTrue(passed);
            Assert.IsTrue(string.IsNullOrEmpty(error));
        }

        [Test]
        public void Replaced_Type_makes_code_readeable()
        {
            var result = Storage.Store(5);
            Assert.AreEqual(result, StoreResult.Ok);
        }
    }
}