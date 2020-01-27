using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var continentInfo =
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] dataInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!continentInfo.ContainsKey(dataInput[0]))
                {
                    continentInfo[dataInput[0]] = new Dictionary<string, List<string>>();
                }
                if (!continentInfo[dataInput[0]].ContainsKey(dataInput[1]))
                {
                    continentInfo[dataInput[0]][dataInput[1]] = new List<string>();
                }
                if (continentInfo[dataInput[0]].ContainsKey(dataInput[1]))
                {
                    continentInfo[dataInput[0]][dataInput[1]].Add(dataInput[2]);
                }
            }

            foreach (var continent in continentInfo)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine(country.Key + " -> " + string.Join(", ",country.Value));
                }
            }
        }
    }
}
