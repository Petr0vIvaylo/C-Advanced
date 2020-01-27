using System;
using System.Linq;

namespace Multidimensional_Arrays_Lab
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int sumOfAllElements = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            foreach (var element in matrix)
            {
                sumOfAllElements += element;
            }

            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(sumOfAllElements);
        }
    }
}
