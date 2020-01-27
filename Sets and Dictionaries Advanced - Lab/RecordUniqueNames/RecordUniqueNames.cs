using System;
using System.Linq;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int countOfNamesToRead = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < countOfNamesToRead; i++)
            {
                string nameInput = Console.ReadLine();

                uniqueNames.Add(nameInput);
            }
            Console.WriteLine(string.Join('\n', uniqueNames));
        }
    }
}
