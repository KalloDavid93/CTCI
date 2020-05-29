using CTCI_solutions.Chapter2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CTCI_tests.Chapter2
{
    public class LoopDetectionTest
    {
        private LoopDetection loopDetection;

        [SetUp]
        public void Setup()
        {
            loopDetection = new LoopDetection();
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
            LinkedListNode<int> loopStart = new LinkedListNode<int>(6);
            list.AddLast(loopStart);
        }
    }
}
