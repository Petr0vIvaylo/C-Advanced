using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<long, int> numberAppearance = new Dictionary<long, int>(n);

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numberAppearance.ContainsKey(input))
                {
                    numberAppearance[input] = 0;
                }
                else
                {
                    numberAppearance[input]++;
                }
            }

            foreach (var num in numberAppearance)
            {
                if (num.Value > 0)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }
        }
    }
}
