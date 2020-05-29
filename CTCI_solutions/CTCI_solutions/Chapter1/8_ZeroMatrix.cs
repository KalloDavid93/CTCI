using System.Collections.Generic;

namespace CTCI_solutions.Chapter1
{
    public class ZeroMatrix
    {
        public int[][] Zero(int[][] matrix)
        {
            int numOfRows = matrix.Length;
            int numOfCols = matrix[0].Length;
            
            List<int> rowsToZero = new List<int>();
            List<int> colsToZero = new List<int>();

            for (int row = 0; row < numOfRows; row++)
            {
                for (int col = 0; col < numOfCols; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        if (!rowsToZero.Contains(row)) { rowsToZero.Add(row); }
                        if (!colsToZero.Contains(col)) { colsToZero.Add(col); }
                    }
                }
            }

            foreach (int row in rowsToZero)
            {
                for (int col = 0; col < numOfCols; col++) { matrix[row][col] = 0; }
            }

            foreach (int col in colsToZero)
            {
                for (int row = 0; row < numOfRows; row++) { matrix[row][col] = 0; }
            }

            return matrix;
        }
    }
}
