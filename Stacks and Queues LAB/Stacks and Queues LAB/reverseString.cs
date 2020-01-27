using System;
using System.Collections.Generic;

namespace Stacks_and_Queues_LAB
{
    class reverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> reversedStr = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                reversedStr.Push(input[i].ToString());
            }
            
                
            Console.WriteLine(string.Join("",reversedStr));
        }
    }
}
