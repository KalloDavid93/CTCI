namespace CTCI_solutions.Chapter1
{
    public class RotateMatrix
    {
        public int[][] Rotate(int[][] matrix)
        {
            int length = matrix.Length;
            int[][] results = new int[length][];
            for (int col = 0; col < length; col++)
            {
                int[] inner = new int[length];
                for (int row = 0; row < length; row++)
                {
                    int item = matrix[row][col];
                    inner[length - row - 1] = item;
                }
                results[col] = inner;
            }
            return results;
        }
    }
}
