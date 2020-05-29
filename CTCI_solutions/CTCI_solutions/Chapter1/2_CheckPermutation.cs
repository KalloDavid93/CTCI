using System.Collections.Generic;

namespace CTCI_solutions.Chapter1
{
    public class CheckPermutation
    {
        public bool ArePermutations(string str1, string str2)
        {
            if (str1.Length != str2.Length) { return false; }
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                char c = str1[i];
                if (dict1.ContainsKey(c)) { dict1[c]++; }
                else { dict1.Add(c, 1); }

                c = str2[i];
                if (dict2.ContainsKey(c)) { dict2[c]++; }
                else { dict2.Add(c, 1); }
            }

            foreach (KeyValuePair<char, int> entry in dict1)
            {
                if (!dict2.ContainsKey(entry.Key) || entry.Value != dict2[entry.Key]) { return false; }
            }

            return true;
        }
    }
}
