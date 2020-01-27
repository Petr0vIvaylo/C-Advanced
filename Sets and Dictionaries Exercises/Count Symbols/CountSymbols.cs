using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
             
            SortedDictionary<char, int> occurrences = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurrences.ContainsKey(input[i]))
                {
                    occurrences[input[i]] = 1;
                }
                else
                {
                    occurrences[input[i]]++;
                }
            }

            foreach (var character in occurrences)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
