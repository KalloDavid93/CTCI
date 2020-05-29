using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class URLifyTest
    {
        private URLify uRLify;

        [SetUp]
        public void Setup()
        {
            uRLify = new URLify();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Mr%20John%20Smith", uRLify.ReplaceWhiteSpace("Mr John Smith    "));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("quick%20brown%20fox%20jumps%20over%20the%20lazy%20dog", uRLify.ReplaceWhiteSpace("quick brown fox jumps over the lazy dog"));
        }
    }
}
