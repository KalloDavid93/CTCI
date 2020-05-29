using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class StringCompressionTest
    {
        private StringCompression stringCompression;

        [SetUp]
        public void Setup()
        {
            stringCompression = new StringCompression();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("a3b2c6a2", stringCompression.CompressString("aaabbccccccaa"));
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual("aabbcde", stringCompression.CompressString("aabbcde"));
        }
    }
}
