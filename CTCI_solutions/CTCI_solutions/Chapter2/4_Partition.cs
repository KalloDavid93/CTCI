namespace CTCI_solutions.Chapter2
{
    public class Partition
    {
        public MyLinkedList Organize(MyLinkedList list, int partition)
        {
            MyLinkedList left = new MyLinkedList();
            MyLinkedList right = new MyLinkedList();
            MyNode current = list.First;
            while (current.Next != null)
            {
                if (current.Value < partition)
                {
                    if (left.Count == 0) { left.AddFirst(current); }
                    else { left.AddLast(current); }
                }
                else
                {
                    if (right.Count == 0) { right.AddFirst(current); }
                    else { right.AddLast(current); }
                }
                current = current.Next;
            }
            MyLinkedList result = new MyLinkedList(left);
            result.Last.Next = right.First;
            return result;
        }
    }
}
