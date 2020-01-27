using System;
using System.Collections.Generic;

namespace _6._Traffic_Jam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int numberOfCarsPass = int.Parse(Console.ReadLine());
            string input;
            int carPassedCounter = 0;
            var carQueue = new Queue<string>();

            while ( (input = Console.ReadLine()) != "end" )
            {
                if (input != "green")
                {
                    carQueue.Enqueue(input);
                }
                else if (input == "green")
                {
                    for (int i = 0; i < numberOfCarsPass; i++)
                    {
                        if (carQueue.Count > 0)
                        {
                            Console.WriteLine($"{carQueue.Dequeue()} passed!");
                            carPassedCounter++;
                        }
                    }
                }
            }
            Console.WriteLine($"{carPassedCounter} cars passed the crossroads.");
        }
    }
}
