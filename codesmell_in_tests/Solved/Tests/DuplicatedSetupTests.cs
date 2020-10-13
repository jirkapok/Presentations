using System;
using NUnit.Framework;
using Suite;

namespace Tests
{
    [TestFixture]
    public class DuplicatedSetupTests
    {
        // code smell:
        // - Tests multiple things
        // - use less comments
        // - Repeated setup

        [Test]
        public void Merge_repeated_code_snd_test_only_one_thing()
        {
            // Execute after dispose.
            Assert.Throws<ObjectDisposedException>(
                () =>
                {
                    var sut = new Disposable();
                    sut.Dispose();
                    sut.Execute();
                });

            // Repeated dispose
            Assert.Throws<ObjectDisposedException>(
                () =>
                {
                    var sut = new Disposable();
                    sut.Dispose();
                    sut.Dispose();
                });
        }
    }
}