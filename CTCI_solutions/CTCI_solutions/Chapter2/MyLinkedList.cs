using System.Diagnostics;

namespace CTCI_solutions.Chapter2
{
    public class MyLinkedList
    {
        public int Count { get { return CountElements(); } }
        public MyNode First { get; set; }
        public MyNode Last { get; set; }

        public MyLinkedList() { }
        public MyLinkedList(MyLinkedList list)
        {
            this.First = list.First;
            this.Last = list.Last;
        }
        public MyLinkedList(MyNode first)
        {
            First = first;
            Last = first;
        }

        public void AddLast(MyNode node)
        {
            if (Count == 0) { First = node; }
            else
            {
                Last.Next = node;
                node.Previous = Last;
            }
            Last = node;
            node.Next = null;
        }

        public void AddFirst(MyNode node)
        {
            if (Count == 0) { Last = node; }
            else
            {
                First.Previous = node;
                node.Next = First;
            }
            First = node;
            node.Previous = null;
        }

        public void RemoveLast()
        {
            Last = Last.Previous;
        }

        public void RemoveFirst()
        {
            First = First.Next;
        }

        private int CountElements()
        {
            if (First == null) { return 0; }
            int counter = 1;
            MyNode current = First;
            while (current.Next != null)
            {
                counter++;
                current = current.Next;
            }
            return counter;
        }
    }
}
