using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNamesCollection = new HashSet<string>(n);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                uniqueNamesCollection.Add(input);
            }

            foreach (var item in uniqueNamesCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
