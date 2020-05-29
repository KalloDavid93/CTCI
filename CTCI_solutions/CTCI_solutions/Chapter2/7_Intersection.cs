using System;
using System.Collections.Generic;

namespace CTCI_solutions.Chapter2
{
    public class Intersection
    {
        public LinkedListNode<int> FindIntersectingNode(LinkedList<int> listA, LinkedList<int> listB)
        {
            if (listA == null || listA.Count == 0 ||
                listB == null || listB.Count == 0 ||
                listA.Last != listB.Last) { return null; }

            LinkedList<int> shorterList = listA.Count < listB.Count ? listA : listB;
            LinkedList<int> longerList = listA.Count < listB.Count ? listB : listA;

            LinkedListNode<int> shorterCurrent = shorterList.First;
            LinkedListNode<int> longerCurrent = longerList.First;
            ReturnKthToLast returnKthToLast = new ReturnKthToLast();
            longerCurrent = returnKthToLast.ReturnNodeFromEnd(longerList, Math.Abs(listA.Count - listB.Count));

            while (shorterCurrent != longerCurrent)
            {
                shorterCurrent = shorterCurrent.Next;
                longerCurrent = longerCurrent.Next;
            }

            return shorterCurrent;
        }
    }
}
