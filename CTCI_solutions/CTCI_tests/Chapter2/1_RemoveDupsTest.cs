using NUnit.Framework;
using CTCI_solutions.Chapter2;

namespace CTCI_tests.Chapter2
{
    class RemoveDupsTest
    {
        private RemoveDups removeDups;

        [SetUp]
        public void Setup()
        {
            removeDups = new RemoveDups();
        }

        [Test]
        public void Test1()
        {
            MyLinkedList list = new MyLinkedList();
            for (int i = 1; i < 10; i++) { list.AddLast(new MyNode(i)); }
            int initCount = list.Count;
            removeDups.RemoveDuplicates(list.First);
            int newCount = list.Count;
            Assert.AreEqual(initCount, newCount);
        }

        [Test]
        public void Test2()
        {
            MyLinkedList list = new MyLinkedList();
            list.AddLast(new MyNode(1));
            list.AddLast(new MyNode(2));
            list.AddLast(new MyNode(3));
            list.AddLast(new MyNode(4));
            list.AddLast(new MyNode(3));
            list.AddLast(new MyNode(5));
            int initCount = list.Count;
            removeDups.RemoveDuplicates(list.First);
            int newCount = list.Count;
            Assert.AreEqual(initCount, newCount + 1);
        }
    }
}
