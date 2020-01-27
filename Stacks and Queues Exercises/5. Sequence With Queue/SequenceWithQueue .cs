using System;
using System.Collections.Generic;

class SequenceWithQueue
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Queue<long> sequence = new Queue<long>();

        sequence.Enqueue(n);

        for (int i = 0; i < 50; i++)
        {
            var element = sequence.Dequeue();
            Console.Write(element + " ");
            sequence.Enqueue(element + 1); 
            sequence.Enqueue(2 * element + 1); 
            sequence.Enqueue(element + 2);
        }
        Console.WriteLine();
    }
}

