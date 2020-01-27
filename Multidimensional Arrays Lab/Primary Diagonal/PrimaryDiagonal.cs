using System;
using System.Linq;

namespace Primary_Diagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            long matrixSize = long.Parse(Console.ReadLine());

            long[,] matrix = new long[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            long diagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) ; col++)
                {
                    if (matrix[row, col] == matrix[col, row])
                    {
                        diagonalSum += matrix[col, row];
                        break;
                    }
                    
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
