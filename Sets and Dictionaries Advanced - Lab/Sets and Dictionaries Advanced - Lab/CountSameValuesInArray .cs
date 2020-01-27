using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> valuesCount = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!valuesCount.ContainsKey(input[i]))
                {
                    valuesCount[input[i]] = 1;
                }
                else
                {
                    valuesCount[input[i]] += 1;
                }
            }

            foreach (var item in valuesCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
