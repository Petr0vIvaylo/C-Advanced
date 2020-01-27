using System;
using System.Collections.Generic;
using System.Linq;

class BasicQueueOperations
{
    static void Main()
    {
        int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> numsToManipulate = new Queue<int>(inputArr);

        for (int i = 0; i < inputParams[1]; i++)
        {
            numsToManipulate.Dequeue();
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

