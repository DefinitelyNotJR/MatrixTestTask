using System;
using System.Linq;

namespace matrix_test_task.Services.MatrixServices
{
    public class MatrixService : IMatrixService
    {
        public int[][] RandomMatrix()
        {
            Random rnd = new Random();
            int size = rnd.Next(3, 10);
            int[][] rndMatrix = new int[size][];
            try
            {
                for (int i = 0; i < rndMatrix.Length; i++)
                {
                    rndMatrix[i] = new int[size];
                    for (int j = 0; j < rndMatrix[i].Length; j++)
                    {
                        rndMatrix[i][j] = rnd.Next(1, 10);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return rndMatrix;
        }

        public int[][] RotateMatrix(int[][] matrix)
        {

            try
            {
                for (int i = 0; i <= (matrix.GetUpperBound(0)); i++)
                {
                    for (int j = 0; j <= (matrix[i].GetUpperBound(0) / 2); j++)
                    {
                        int temp = matrix[i][j];
                        matrix[i][j] = matrix[i][matrix[i].GetUpperBound(0) - j];
                        matrix[i][matrix[i].GetUpperBound(0) - j] = temp;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return matrix;
        }

        public int[][] TransposeMatrix(string[][] matrix)
        {
            int length = matrix[0].Length;
            int[][] newVal = new int[length][];

            try
            {
                for (int x = 0; x < length; x++)
                {
                    newVal[x] = matrix.Select(p => Int32.Parse(p[x])).ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return newVal;
        }

        public int[][] TransposeMatrix(int[][] matrix)
        {
            int length = matrix[0].Length;
            int[][] newVal = new int[length][];
            try
            {
                for (int x = 0; x < length; x++)
                {
                    newVal[x] = matrix.Select(p => p[x]).ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return newVal;
        }
    }
}