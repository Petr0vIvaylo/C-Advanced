using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> vLoggers = new Dictionary<string, HashSet<string>>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Statistics")
            {
                if (input[1] == "joined")
                {
                    if (!vLoggers.ContainsKey(input[0]))
                    {
                        vLoggers[input[0]] = new HashSet<string>();
                    }
                }
                else if (input[1] == "followed")
                {
                    if ((vLoggers.ContainsKey(input[2]) && vLoggers.ContainsKey(input[0]))
                        && (vLoggers[input[2]] != vLoggers[input[0]]))
                    {
                        vLoggers[input[2]].Add(input[0]);
                    }
                }
                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            var folowers = new Dictionary<string, int>();
            foreach (var name in vLoggers)
            {
                foreach (var item in name.Value)
                {
                    if (!folowers.ContainsKey(item))
                    {
                        folowers[item] = 1;
                    }
                    else
                    {
                        folowers[item]++;
                    }

                }
            }


            if (input[0] == "Statistics")
            {
                Console.WriteLine($"The V-Logger has a total of {vLoggers.Count} vloggers in its logs.");

                var orderedVLoggers = vLoggers.OrderByDescending(n => n.Value.Count)
                    .ToDictionary(v => v.Key, s => s.Value);
                int counter = 1;
                foreach (var vlogerName in orderedVLoggers)
                {

                    Console.Write($"{counter}. {vlogerName.Key} : {vlogerName.Value.Count} followers, ");
                    if (folowers.ContainsKey(vlogerName.Key))
                    {
                        Console.WriteLine($"{folowers[vlogerName.Key]} following");
                    }
                    else
                    {
                        Console.WriteLine("0 following");
                    }
                    var orderedFolowers = vlogerName.Value.OrderBy(s => s);
                    if (counter == 1)
                    {
                        foreach (var name in orderedFolowers)
                        {
                            Console.WriteLine($"*  {name}");
                        }
                    }
                    counter++;
                }
            }
        }
    }
}
