using CTCI_solutions.Chapter2;
using NUnit.Framework;

namespace CTCI_tests.Chapter2
{
    public class PartitionTest
    {
        private Partition partition;

        [SetUp]
        public void Setup()
        {
            partition = new Partition();
        }

        [Test]
        public void Test1()
        {
            MyLinkedList list = new MyLinkedList();
            list.AddLast(new MyNode(12));
            list.AddLast(new MyNode(2));
            list.AddLast(new MyNode(3));
            list.AddLast(new MyNode(14));
            list.AddLast(new MyNode(13));
            list.AddLast(new MyNode(1));
            list.AddLast(new MyNode(4));
            list.AddLast(new MyNode(11));
            list.AddLast(new MyNode(15));
            list.AddLast(new MyNode(5));
        }
    }
}
