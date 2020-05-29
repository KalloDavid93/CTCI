using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class OneAwayTest
    {
        private OneAway oneAway;
        
        [SetUp]
        public void Setup()
        {
            oneAway = new OneAway();
        }

        [Test]
        public void Test1()
        {
            Assert.True(oneAway.IsOneEditAway("pale", "ple"));
        }

        [Test]
        public void Test2()
        {
            Assert.True(oneAway.IsOneEditAway("pales", "pale"));
        }

        [Test]
        public void Test3()
        {
            Assert.True(oneAway.IsOneEditAway("pale", "bale"));
        }

        [Test]
        public void Test4()
        {
            Assert.False(oneAway.IsOneEditAway("pale", "bake"));
        }
    }
}
