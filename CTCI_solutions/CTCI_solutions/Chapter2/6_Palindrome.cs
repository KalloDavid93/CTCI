using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class Palindrome
    {
        public bool IsPalindrome(LinkedListNode<int> head)
        {
            LinkedListNode<int> slow = head;
            LinkedListNode<int> fast = head;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Value);
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast != null) { slow = slow.Next; }
            while (slow != null)
            {
                int top = stack.Pop();
                if (top != slow.Value)
                {
                    return false;
                }
                slow = slow.Next;
            }
            return true;
        }
    }
}
