using NUnit.Framework;
using CTCI_solutions.Chapter2;
using System.Collections.Generic;

namespace CTCI_tests.Chapter2
{
    public class ReturnKthToLastTest
    {
        private ReturnKthToLast returnKthToLast;

        [SetUp]
        public void Setup()
        {
            returnKthToLast = new ReturnKthToLast();
        }

        [Test]
        public void Test1()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(new LinkedListNode<int>(1));
            list.AddLast(new LinkedListNode<int>(2));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(4));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(6));
            Assert.AreEqual(4, returnKthToLast.ReturnNodeFromEnd(list, 2).Value);
        }
    }
}
