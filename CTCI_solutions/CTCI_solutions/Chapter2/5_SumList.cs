using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class SumList
    {
        public int Sum(LinkedList<int> listA, LinkedList<int> listB)
        {
            int sum = 0;
            if (listA.Count > 0)
            {
                LinkedListNode<int> current = listA.Last;
                while (current.Previous != null)
                {
                    sum += current.Value;
                    current = current.Previous;
                }
            }
            if (listB.Count > 0)
            {
                LinkedListNode<int> current = listB.Last;
                while (current.Previous != null)
                {
                    sum += current.Value;
                    current = current.Previous;
                }
            }
            return sum;
        }
    }
}
