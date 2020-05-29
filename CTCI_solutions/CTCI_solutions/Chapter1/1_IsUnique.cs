using System.Collections.Generic;

namespace CTCI_solutions.Chapter1
{
    public class IsUnique
    {
        public bool AreCharsUnique(string s)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                if (set.Contains(c)) { return false; }
                else { set.Add(c); }
            }
            return true;
        }
    }
}
