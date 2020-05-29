using CTCI_solutions.Chapter2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CTCI_tests.Chapter2
{
    public class PalindromeTest
    {
        private Palindrome palindrome;

        [SetUp]
        public void Setup()
        {
            palindrome = new Palindrome();
        }

        [Test]
        public void Test1()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(new LinkedListNode<int>(10));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(7));
            list.AddLast(new LinkedListNode<int>(2));
            list.AddLast(new LinkedListNode<int>(3));
            Assert.IsFalse(palindrome.IsPalindrome(list.First));
        }

        [Test]
        public void Test2()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(new LinkedListNode<int>(10));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(7));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(10));
            Assert.IsTrue(palindrome.IsPalindrome(list.First));
        }

        [Test]
        public void Test3()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(new LinkedListNode<int>(10));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(7));
            list.AddLast(new LinkedListNode<int>(7));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(5));
            list.AddLast(new LinkedListNode<int>(10));
            Assert.IsTrue(palindrome.IsPalindrome(list.First));
        }
    }
}
