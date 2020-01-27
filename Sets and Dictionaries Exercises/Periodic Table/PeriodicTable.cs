using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int chemicalCompoundNumber = int.Parse(Console.ReadLine());

            HashSet<string> uniqueChemicalElements = new HashSet<string>();

            for (int i = 0; i < chemicalCompoundNumber; i++)
            {
                string[] chemicalCompounds = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in chemicalCompounds)
                {
                    uniqueChemicalElements.Add(element);
                }
            }
            var orderedElements = uniqueChemicalElements.OrderBy(s => s).ToArray();

            Console.WriteLine(string.Join(' ', orderedElements));
        }
    }
}
