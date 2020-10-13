using System;
using NUnit.Framework;
using Suite;

namespace Tests
{
    [TestFixture]
    public class DuplicatedSetupTests
    {
        // code smell fixed:
        // - Tests multiple things
        // - use less comments
        // - Repeated setup

        private readonly Disposable sut = new Disposable(); // dummy setup

        [Test]
        public void Repeat_Dispose()
        {
            Assert.Throws<ObjectDisposedException>(
                () =>
                {
                    sut.Dispose();
                    sut.Dispose();
                });
        }

        [Test]
        public void Execute_After_Dispose()
        {
            Assert.Throws<ObjectDisposedException>(
                () =>
                {
                    sut.Dispose();
                    sut.Execute();
                });
        }
    }
}