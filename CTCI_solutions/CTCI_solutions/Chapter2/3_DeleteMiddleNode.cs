namespace CTCI_solutions.Chapter2
{
    public class DeleteMiddleNode
    {
        public void DeleteNode(MyLinkedList list, int k)
        {
            MyNode current = list.First;
            int counter = 0;
            while (counter < k)
            {
                current = current.Next;
                counter++;
            }
            current.Previous.Next = current.Next;
            current.Next.Previous = current.Previous;
        }
    }
}
