using CTCI_solutions.Chapter2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CTCI_tests.Chapter2
{
    public class IntersectionTest
    {

        private Intersection intersection;

        [SetUp]
        public void Setup()
        {
            intersection = new Intersection();
        }

        [Test]
        public void Test1()
        {
            LinkedList<int> listA = new LinkedList<int>();
            LinkedList<int> listB = new LinkedList<int>();
            LinkedListNode<int> intersecting = new LinkedListNode<int>(10);
            listA.AddLast(new LinkedListNode<int>(1));
            listA.AddLast(new LinkedListNode<int>(2));
            listA.AddLast(new LinkedListNode<int>(3));
            listA.AddLast(intersecting);
            listA.AddLast(new LinkedListNode<int>(4));
            listA.AddLast(new LinkedListNode<int>(5));
            
            listB.AddLast(new LinkedListNode<int>(6));
            listB.AddLast(new LinkedListNode<int>(7));
            listB.AddLast(new LinkedListNode<int>(8));
            listB.AddLast(intersecting);

            Assert.AreEqual(intersecting, intersection.FindIntersectingNode(listA, listB));
        }

    }
}
