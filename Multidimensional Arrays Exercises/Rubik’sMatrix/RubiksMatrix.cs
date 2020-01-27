using System;
using System.Linq;

namespace Rubik_sMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int commandsToFollow = int.Parse(Console.ReadLine()); 
        }
    }
}
