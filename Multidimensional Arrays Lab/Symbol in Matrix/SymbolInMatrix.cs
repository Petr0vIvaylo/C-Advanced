using System;

namespace Symbol_in_Matrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] matrixElements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
            }
            char symbol = char.Parse( Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix ");
        }
    }
}
