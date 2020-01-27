﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Poisonous_Plants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            int plantsNum = int.Parse(Console.ReadLine());
            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> indexes = new List<int>();
            int days = 0;
            while (true)
            {
                for (int i = 0; i < plants.Count -1; i++)
                {
                    if (plants[i] < plants[i + 1])
                    {
                        indexes.Add(i + 1);
                    }
                }
                for (int i = indexes.Count - 1; i >= 0; i--)
                {
                    plants.RemoveAt(indexes[i]);
                }
                if (indexes.Count == 0)
                {
                    break;
                }
                indexes.Clear();
                days++;
                
            }
            Console.WriteLine(days);
        }
    }
}
