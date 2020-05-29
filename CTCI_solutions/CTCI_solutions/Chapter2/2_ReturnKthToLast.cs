using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class ReturnKthToLast
    {
        public LinkedListNode<int> ReturnNodeFromEnd(LinkedList<int> list, int k)
        {
            LinkedListNode<int> current = list.Last;
            int counter = 0;
            while (counter < k)
            {
                current = current.Previous;
                counter++;
            }
            return current;
        }
    }
}
