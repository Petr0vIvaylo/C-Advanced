using System;
using System.Collections.Generic;
using System.Linq;


class MaximumElement
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> elementStack = new Stack<int>();
        
        for (int i = 0; i < n; i++)
        {
            int[] inputSeq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            switch (inputSeq[0])
            {
                case 1: elementStack.Push(inputSeq[1]);break;
                case 2: elementStack.Pop();break;
                case 3: Console.WriteLine(elementStack.Max());break;
                default:
                    Console.WriteLine("invalid command !");
                    break;
            }
        }
    }
}

