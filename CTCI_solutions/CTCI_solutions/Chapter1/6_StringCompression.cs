namespace CTCI_solutions.Chapter1
{
    public class StringCompression
    {
        private int currentLength = 1;
        private char lastChar = ' ';
        private string result = "";

        public string CompressString(string s)
        {
            foreach (char c in s)
            {
                if (c.Equals(lastChar))
                {
                    currentLength++;
                }
                else
                {
                    if (!lastChar.Equals(' '))
                    {
                        AddChars();
                        currentLength = 1;
                    }
                }
                lastChar = c;
            }
            AddChars();

            if (result.Length >= s.Length) { return s; }
            else { return result; }
        }

        private void AddChars()
        {
            result += lastChar;
            result += currentLength.ToString();
        }
    }
}
