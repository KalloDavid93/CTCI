using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class LoopDetection
    {
        public LinkedListNode<int> GetNoodFromLoop(LinkedListNode<int> head)
        {
            LinkedListNode<int> current = head;
            HashSet<LinkedListNode<int>> set = new HashSet<LinkedListNode<int>>();

            while (!set.Contains(current.Next))
            {
                set.Add(current);
                current = current.Next;
            }

            return current.Next;
        }
    }
}
