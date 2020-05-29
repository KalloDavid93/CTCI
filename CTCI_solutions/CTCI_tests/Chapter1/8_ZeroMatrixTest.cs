using NUnit.Framework;
using CTCI_solutions.Chapter1;

namespace CTCI_tests.Chapter1
{
    public class ZeroMatrixTest
    {
        private ZeroMatrix zeroMatrix;

        [SetUp]
        public void Setup()
        {
            zeroMatrix = new ZeroMatrix();
        }

        [Test]
        public void Test1()
        {
            int[] row1 = { 1, 1, 1, 1 };
            int[] row2 = { 2, 2, 2, 1 };
            int[] row3 = { 3, 3, 1, 2 };
            int[] row4 = { 3, 0, 3, 1 };
            int[][] matrix = { row1, row2, row3, row4 };

            int[] testRow1 = { 1, 0, 1, 1 };
            int[] testRow2 = { 2, 0, 2, 1 };
            int[] testRow3 = { 3, 0, 1, 2 };
            int[] testRow4 = { 0, 0, 0, 0 };
            int[][] testMatrix = { testRow1, testRow2, testRow3, testRow4 };
            Assert.AreEqual(testMatrix, zeroMatrix.Zero(matrix));
        }

        [Test]
        public void Test2()
        {
            int[] row1 = { 1, 1, 1, 0 };
            int[] row2 = { 2, 2, 2, 1 };
            int[] row3 = { 3, 3, 1, 2 };
            int[] row4 = { 0, 2, 3, 1 };
            int[][] matrix = { row1, row2, row3, row4 };

            int[] testRow1 = { 0, 0, 0, 0 };
            int[] testRow2 = { 0, 2, 2, 0 };
            int[] testRow3 = { 0, 3, 1, 0 };
            int[] testRow4 = { 0, 0, 0, 0 };
            int[][] testMatrix = { testRow1, testRow2, testRow3, testRow4 };
            Assert.AreEqual(testMatrix, zeroMatrix.Zero(matrix));
        }

        [Test]
        public void Test3()
        {
            int[] row1 = { 1, 1, 1, 2 };
            int[] row2 = { 2, 0, 2, 1 };
            int[] row3 = { 3, 3, 0, 2 };
            int[] row4 = { 1, 2, 3, 1 };
            int[][] matrix = { row1, row2, row3, row4 };

            int[] testRow1 = { 1, 0, 0, 2 };
            int[] testRow2 = { 0, 0, 0, 0 };
            int[] testRow3 = { 0, 0, 0, 0 };
            int[] testRow4 = { 1, 0, 0, 1 };
            int[][] testMatrix = { testRow1, testRow2, testRow3, testRow4 };
            Assert.AreEqual(testMatrix, zeroMatrix.Zero(matrix));
        }

        [Test]
        public void Test4()
        {
            int[] row1 = { 1, 1, 1, 0 };
            int[] row2 = { 2, 2, 0, 1 };
            int[] row3 = { 3, 0, 1, 2 };
            int[] row4 = { 0, 2, 3, 1 };
            int[][] matrix = { row1, row2, row3, row4 };

            int[] testRow1 = { 0, 0, 0, 0 };
            int[] testRow2 = { 0, 0, 0, 0 };
            int[] testRow3 = { 0, 0, 0, 0 };
            int[] testRow4 = { 0, 0, 0, 0 };
            int[][] testMatrix = { testRow1, testRow2, testRow3, testRow4 };
            Assert.AreEqual(testMatrix, zeroMatrix.Zero(matrix));
        }
    }
}
