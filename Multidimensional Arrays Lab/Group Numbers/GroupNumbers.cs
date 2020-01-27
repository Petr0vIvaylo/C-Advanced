using System;
using System.Linq;
using System.Collections.Generic;

namespace Group_Numbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            var groups = input.GroupBy(n => RemainderChecker(n)).OrderBy(n => n.Key);

            foreach (var g in groups)
            {
                Console.WriteLine(string.Join(' ', g));
            }

        }

        static int RemainderChecker(int value)
        {
            if (value % 3 == 2 || value % 3 == -2)
            {
                return 2;
            }
            else if (value % 3 == 1 || value % 3 == -1)
            {
                return 1;
            }
            else if (value % 3 == 0)
            {
                return 0;
            }
            else
            {
                return 666;
            }
        }

    }
}
