using System.Collections.Generic;

namespace CTCI_solutions.Chapter1
{
    public class PalindromePermutation
    {
        public bool IsPermutationOfPalindrome(string s)
        {
            s = s.Replace(" ", "");
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c)) { dict[c]++; }
                else { dict.Add(c, 1); }
            }
            if (s.Length % 2 == 0)
            {
                foreach (KeyValuePair<char, int> entry in dict)
                {
                    if (entry.Value % 2 != 0) { return false; }
                }
            }
            else
            {
                bool oddFound = false;
                foreach (KeyValuePair<char, int> entry in dict)
                {
                    if (entry.Value % 2 != 0)
                    {
                        if (oddFound) { return false; }
                    }
                }
            }
            return true;
        }
    }
}
