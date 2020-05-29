using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class RotateMatrixTest
    {
        private RotateMatrix rotateMatrix;
        private int[][] matrix;

        [SetUp]
        public void Setup()
        {
            rotateMatrix = new RotateMatrix();
            int[] row1 = { 1, 2, 3, 4 };
            int[] row2 = { 5, 6, 7, 8 };
            int[] row3 = { 9, 10, 11, 12 };
            int[] row4 = { 13, 14, 15, 16 };
            matrix = new int[][] { row1, row2, row3, row4 };

        }

        [Test]
        public void Test1()
        {
            int[] row1 = { 13, 9, 5, 1 };
            int[] row2 = { 14, 10, 6, 2 };
            int[] row3 = { 15, 11, 7, 3 };
            int[] row4 = { 16, 12, 8, 4 };
            int[][] testGrid = { row1, row2, row3, row4 };
            Assert.AreEqual(testGrid, rotateMatrix.Rotate(matrix));
        }

        [Test]
        public void Test2()
        {
            int[] row1 = { 16, 15, 14, 13 };
            int[] row2 = { 12, 11, 10, 9 };
            int[] row3 = { 8, 7, 6, 5 };
            int[] row4 = { 4, 3, 2, 1 };
            int[][] testGrid = { row1, row2, row3, row4 };
            int[][] newMatrix = rotateMatrix.Rotate(matrix);
            Assert.AreEqual(testGrid, rotateMatrix.Rotate(newMatrix));
        }

        [Test]
        public void Test3()
        {
            int[] row1 = { 4, 8, 12, 16 };
            int[] row2 = { 3, 7, 11, 15 };
            int[] row3 = { 2, 6, 10, 14 };
            int[] row4 = { 1, 5, 9, 13 };
            int[][] testGrid = { row1, row2, row3, row4 };
            int[][] newMatrix = rotateMatrix.Rotate(matrix);
            newMatrix = rotateMatrix.Rotate(newMatrix);
            Assert.AreEqual(testGrid, rotateMatrix.Rotate(newMatrix));
        }

        [Test]
        public void Test4()
        {
            int[][] newMatrix = rotateMatrix.Rotate(matrix);
            newMatrix = rotateMatrix.Rotate(newMatrix);
            newMatrix = rotateMatrix.Rotate(newMatrix);
            Assert.AreEqual(matrix, rotateMatrix.Rotate(newMatrix));
        }
    }
}
