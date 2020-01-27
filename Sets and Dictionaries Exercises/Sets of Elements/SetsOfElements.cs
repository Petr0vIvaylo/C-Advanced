using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] collectionsLength = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> n = new HashSet<int>(collectionsLength[0]);
            HashSet<int> m = new HashSet<int>(collectionsLength[1]);

            for (int i = 0; i < collectionsLength[0]; i++)
            {
                n.Add(InputRead());
            }
            for (int i = 0; i < collectionsLength[1]; i++)
            {
                m.Add(InputRead());
            }

            List<int> repeatingElements = n.Intersect(m).ToList();

            Console.WriteLine(string.Join(' ', repeatingElements));
        }

        private static int InputRead()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
