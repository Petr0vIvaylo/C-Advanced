using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int matrixRowCount = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRowCount][];

            for (int row = 0; row < matrixRowCount; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = new int[colElements.Length];

                for (int col = 0; col < colElements.Length; col++)
                {
                    jaggedArray[row][col] = colElements[col];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {

                int rowIndex = int.Parse(command[1]);
                int colIndex = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if ((rowIndex < 0 || rowIndex > jaggedArray.Length - 1)
                || (colIndex < 0 || colIndex > jaggedArray[rowIndex].Length - 1))
                {
                    Console.WriteLine("Invalid coordinates");
                    
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                        
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                        
                    }
                }

                command = Console.ReadLine().Split();
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(' ', jaggedArray[i]));
            }
        }
    }
}
