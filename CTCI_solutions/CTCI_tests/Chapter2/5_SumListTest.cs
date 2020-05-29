using CTCI_solutions.Chapter2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CTCI_tests.Chapter2
{
    public class SumListTest
    {
        private SumList sumList;

        [SetUp]
        public void Setup()
        {
            sumList = new SumList();
        }

        [Test]
        public void Test1()
        {
            LinkedList<int> listA = new LinkedList<int>();
            listA.AddLast(new LinkedListNode<int>(10));
            listA.AddLast(new LinkedListNode<int>(5));
            listA.AddLast(new LinkedListNode<int>(3));

            LinkedList<int> listB = new LinkedList<int>();
            listB.AddLast(new LinkedListNode<int>(14));
            listB.AddLast(new LinkedListNode<int>(24));
            listB.AddLast(new LinkedListNode<int>(1));

            Assert.AreEqual(57, sumList.Sum(listA, listB));
        }
    }
}
