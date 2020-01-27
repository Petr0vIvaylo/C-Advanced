using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] matrixElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
            }
            int startIndexRow = 0;
            int startIndexCol = 0;
            int sumOfMaxElements = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSumOfElements= matrix[row, col] + matrix[row, col + 1]
                                       + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sumOfMaxElements < currentSumOfElements)
                    {
                        sumOfMaxElements = currentSumOfElements;
                        startIndexRow = row;
                        startIndexCol = col;
                    }
                }
            }

            Console.WriteLine
                ($"{matrix[startIndexRow, startIndexCol]} {matrix[startIndexRow, startIndexCol + 1]}");

            Console.WriteLine
                ($"{matrix[startIndexRow + 1, startIndexCol]} {matrix[startIndexRow + 1, startIndexCol + 1]}");

            Console.WriteLine(sumOfMaxElements);
        }
    }
}
