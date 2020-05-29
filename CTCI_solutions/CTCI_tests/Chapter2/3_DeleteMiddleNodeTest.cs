using NUnit.Framework;
using CTCI_solutions.Chapter2;

namespace CTCI_tests.Chapter2
{
    public class DeleteMiddleNodeTest
    {
        private DeleteMiddleNode deleteMiddleNode;

        [SetUp]
        public void Setup()
        {
            deleteMiddleNode = new DeleteMiddleNode();
        }

        [Test]
        public void Test1()
        {
            MyLinkedList list = new MyLinkedList();
            list.AddLast(new MyNode(1));
            list.AddLast(new MyNode(2));
            list.AddLast(new MyNode(3));
            list.AddLast(new MyNode(4));
            list.AddLast(new MyNode(5));
            int initCount = list.Count;
            deleteMiddleNode.DeleteNode(list, 3);
            int newCount = list.Count;
            Assert.AreEqual(initCount, newCount + 1);
        }
    }
}
