using System;
using System.Collections.Generic;
using System.Linq;

class BasicStackOperations
{
    static void Main()
    {

        int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> numsToManipulate = new Stack<int>(inputArr);

        for (int i = 0; i < inputParams[1]; i++)
        {
            numsToManipulate.Pop();
        }

        if (numsToManipulate.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (numsToManipulate.Contains(inputParams[2]))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(numsToManipulate.Min());
        }
    }
}

