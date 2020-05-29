using System;

namespace CTCI_solutions.Chapter1
{
    public class OneAway
    {
        public bool IsOneEditAway(string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1) { return false; }
            int difference = 0;
            int aIndex = 0;
            int bIndex = 0;

            while (difference < 2 && aIndex < a.Length && bIndex < b.Length)
            {
                if (!a[aIndex].Equals(b[bIndex]))
                {
                    difference++;
                    if (a[aIndex + 1].Equals(b[bIndex])) { aIndex++; }
                    else if(a[aIndex].Equals(b[bIndex + 1])) { bIndex++; }
                }
                aIndex++;
                bIndex++;
            }
            return difference < 2;
        }
    }
}
