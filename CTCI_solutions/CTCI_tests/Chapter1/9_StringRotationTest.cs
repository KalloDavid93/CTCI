using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class StringRotationTest
    {
        private StringRotation stringRotation;

        [SetUp]
        public void Setup()
        {
            stringRotation = new StringRotation();
        }

        [Test]
        public void Test1()
        {
            Assert.True(stringRotation.IsSubString("waterbottle", "erbottlewat"));
        }

    }
}
