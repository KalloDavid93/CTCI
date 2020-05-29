namespace CTCI_solutions.Chapter1
{
    public class StringRotation
    {
        public bool IsSubString(string s1, string s2)
        {
            if (s1.Length != s2.Length) { return false; }
            for (int i = 0; i < s1.Length; i++)
            {
                string left = s1.Remove(i);
                string right = s1.Remove(0, i);
                string newStr = right + left;
                if (newStr.Equals(s2)) { return true; }
            }
            return false;
        }
    }
}
