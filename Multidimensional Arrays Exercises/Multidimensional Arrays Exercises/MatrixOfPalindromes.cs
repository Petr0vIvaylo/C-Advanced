using System;
using System.Linq;

namespace Multidimensional_Arrays_Exercises
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] =
                                       (alphabet[row].ToString()
                                       + alphabet[col + row].ToString()
                                       + alphabet[row].ToString())
                                       .ToString();

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
                    