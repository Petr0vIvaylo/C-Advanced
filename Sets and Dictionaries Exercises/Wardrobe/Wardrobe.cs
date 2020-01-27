using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>(n);

            for (int i = 0; i < n; i++)
            {
                string[] color = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color[0]))
                {
                    wardrobe[color[0]] = new Dictionary<string, int>();

                    string[] clothes = color[1].Split(',').ToArray();

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[color[0]].ContainsKey(clothes[j]))
                        {
                            wardrobe[color[0]][clothes[j]] = 1;
                        }
                        else
                        {
                            wardrobe[color[0]][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    string[] clothes = color[1].Split(',').ToArray();

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[color[0]].ContainsKey(clothes[j]))
                        {
                            wardrobe[color[0]][clothes[j]] = 1;
                        }
                        else
                        {
                            wardrobe[color[0]][clothes[j]]++;
                        }
                    }
                }
            }
            string[] itemSearch = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == itemSearch[0] && item.Key == itemSearch[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
                
            }
        }
    }
}
