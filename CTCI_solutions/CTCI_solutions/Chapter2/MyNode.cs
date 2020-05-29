namespace CTCI_solutions.Chapter2
{
    public class MyNode
    {
        public int Value { get; set; }
        public MyNode Previous { get; set; }
        public MyNode Next { get; set; }

        public MyNode(int value)
        {
            Value = value;
        }
    }
}

