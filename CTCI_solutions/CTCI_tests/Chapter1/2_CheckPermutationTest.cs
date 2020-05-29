using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class CheckPermutationTest
    {
        private CheckPermutation checkPermutation;

        [SetUp]
        public void Setup()
        {
            checkPermutation = new CheckPermutation();
        }

        [Test]
        public void Test1()
        {
            Assert.True(checkPermutation.ArePermutations("abba", "baba"));
        }

        [Test]
        public void Test2()
        {
            Assert.True(checkPermutation.ArePermutations("qqqasdfghjmnbvoopkkl", "mbqnkgljshoqavopdfkq"));
        }

        [Test]
        public void Test3()
        {
            Assert.True(checkPermutation.ArePermutations("quick brown fox jumps over the lazy dog", "abcdeefghijklmnoooopqrrstuuvwxyz       "));
        }

        [Test]
        public void Test4()
        {
            Assert.False(checkPermutation.ArePermutations("codecool", "greenfox"));
        }
    }
}
