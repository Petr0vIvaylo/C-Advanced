using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            long matrixSize = long.Parse(Console.ReadLine());

            long[,] matrix = new long[matrixSize, matrixSize];

            for (long row = 0; row < matrixSize; row++)
            {
                long[] rowElements = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                for (long col = 0; col < matrixSize; col++)
                {
                    matrix[col, row] = rowElements[col];
                }
            }

            long primaryDiagonalSum = 0;
            long secondaryDiagonalSum = 0;

            for (long cols = 0; cols < matrixSize; cols++)
            {
                primaryDiagonalSum += matrix[cols, cols];
                secondaryDiagonalSum += matrix[cols, matrixSize - cols - 1];
                
            }
        
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
