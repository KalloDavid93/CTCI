using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests
{
    public class IsUniqueTest
    {
        private IsUnique isUnique;

        [SetUp]
        public void Setup()
        {
            isUnique = new IsUnique();
        }

        [Test]
        public void Test1()
        {
            Assert.True(isUnique.AreCharsUnique("abcdefg"));
        }

        [Test]
        public void Test2()
        {
            Assert.True(isUnique.AreCharsUnique("1234567"));
        }

        [Test]
        public void Test3()
        {
            Assert.False(isUnique.AreCharsUnique("abcdagh"));
        }
    }
}