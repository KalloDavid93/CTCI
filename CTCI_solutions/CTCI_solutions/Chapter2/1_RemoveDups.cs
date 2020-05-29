using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class RemoveDups
    {
        public void RemoveDuplicates(MyNode head)
        {
            if (head == null) { return; }
            HashSet<int> set = new HashSet<int>();
            MyNode current = head;
            while (current != null)
            {
                if (!set.Contains(current.Value))
                {
                    set.Add(current.Value);
                }
                else { current.Previous.Next = current.Next; }
                current = current.Next;
            }
        }
    }
}
