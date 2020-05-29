using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class PalindromePermutationTest
    {
        private PalindromePermutation palindromePermutation;

        [SetUp]
        public void Setup()
        {
            palindromePermutation = new PalindromePermutation();
        }

        [Test]
        public void Test1()
        {
            Assert.True(palindromePermutation.IsPermutationOfPalindrome("tact coa"));
        }

        [Test]
        public void Test2()
        {
            Assert.True(palindromePermutation.IsPermutationOfPalindrome("keretkarakterek"));
        }

        [Test]
        public void Test3()
        {
            Assert.True(palindromePermutation.IsPermutationOfPalindrome("indul a gorog aludni"));
        }

        [Test]
        public void Test4()
        {
            Assert.False(palindromePermutation.IsPermutationOfPalindrome("scooby-doo"));
        }
    }
}
