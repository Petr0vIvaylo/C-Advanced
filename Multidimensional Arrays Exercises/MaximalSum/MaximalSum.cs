using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int maxSum = int.MinValue;
            int[,] elementsOfMaxSum = new int[3,3];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col +1] + matrix[row + 2, col + 2] > maxSum)
                    {
                        maxSum = 
                            matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                elementsOfMaxSum[i,j] = matrix[row + i, col + j];
                            }
                             
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < elementsOfMaxSum.GetLength(0); i++)
            {
                for (int j = 0; j < elementsOfMaxSum.GetLength(1); j++)
                {
                    Console.Write(elementsOfMaxSum[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
