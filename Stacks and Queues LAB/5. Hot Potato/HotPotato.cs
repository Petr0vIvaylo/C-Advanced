using System;
using System.Collections.Generic;
namespace _5._Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine().Split();
            int toss = int.Parse(Console.ReadLine());
            var queueNames = new Queue<string>(userInput);

            while (queueNames.Count > 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    queueNames.Enqueue(queueNames.Dequeue());
                }
                Console.WriteLine($"Removed {queueNames.Dequeue()}");
            }
            Console.WriteLine($"Last is {queueNames.Dequeue()}");
        }
    }
}
