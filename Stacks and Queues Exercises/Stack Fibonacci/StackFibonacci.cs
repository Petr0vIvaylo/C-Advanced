using System;
using System.Collections.Generic;

namespace Stack_Fibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Stack<long> fibonaciSequence = new Stack<long>();
            
            fibonaciSequence.Push(0);
            fibonaciSequence.Push(1);
            
            for (int i = 0; i < input - 1; i++)
            {
                long fibonaciLastNum = fibonaciSequence.Pop();
                long fibonaciPrev = fibonaciSequence.Peek();
                long fibonaciSum = fibonaciLastNum + fibonaciPrev;

                fibonaciSequence.Push(fibonaciLastNum);
                fibonaciSequence.Push(fibonaciSum);
            }
            
            Console.WriteLine(fibonaciSequence.Peek());
        }
    }
}
