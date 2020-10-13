using System;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class VerifyOneThingTests
    {
        // code smell fixed:
        // - multiple tests in one
        // - duplicate code in setup and teardown
        // - useless comments
        // - magic constants used

        private static readonly char[] testChars = "0123456789".ToCharArray();

        [Test]
        public void Seek_past_the_end_from_beginning()
        {
            WithStreams((memory, writer) =>
            {
                writer.Seek(11, SeekOrigin.Begin);
                Assert.That(11, Is.EqualTo(memory.Position));
            });
        }

        [Test]
        public void Seeking_past_end_from_middle()
        {
            WithStreams((memory, writer) =>
            {
                writer.Seek(4, SeekOrigin.End);
                Assert.That(14, Is.EqualTo(memory.Position));
            });
        }

        private static void WithStreams(Action<MemoryStream, BinaryWriter> behavior)
        {
            using (var memory = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memory))
                {
                    writer.Write(testChars);
                    behavior(memory, writer);
                }
            }
        }
    }
}