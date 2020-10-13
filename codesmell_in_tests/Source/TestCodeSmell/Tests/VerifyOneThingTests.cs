using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class VerifyOneThingTests
    {
        // code smell:
        // - multiple tests in one
        // - duplicate code in setup and teardown
        // - useless comments
        // - magic constants used
        [Test]
        public void Should_have_only_one_responsibility()
        {
            // [] Seeking past the end from middle
            var mstr = new MemoryStream();
            var dw2 = new BinaryWriter(mstr);
            dw2.Write("0123456789".ToCharArray());
            var lReturn = dw2.Seek(4, SeekOrigin.End); //This won't throw any exception now.

            Assert.That(14, Is.EqualTo(mstr.Position));

            dw2.Dispose();
            mstr.Dispose();

            // [] Seek past the end from beginning
            mstr = new MemoryStream();
            dw2 = new BinaryWriter(mstr);
            dw2.Write("0123456789".ToCharArray());
            lReturn = dw2.Seek(11, SeekOrigin.Begin);  //This won't throw any exception now.

            Assert.That(11, Is.EqualTo(mstr.Position));

            dw2.Dispose();
            mstr.Dispose();
        }
    }
}