using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumpStops = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumpStops.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                int lapFuel = 0;

                foreach (var currentPetrolStop in pumpStops)
                {
                    int fuelAmount = currentPetrolStop[0];
                    int distance = currentPetrolStop[1];
                    lapFuel += fuelAmount - distance;

                    if (lapFuel < 0)
                    {
                        startIndex++;
                        pumpStops.Enqueue(pumpStops.Dequeue());
                        break;
                    }
                }

                if (lapFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
