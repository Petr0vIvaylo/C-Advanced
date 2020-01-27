using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<string, Dictionary<string, double>> shopInfo =
                new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                if (!shopInfo.ContainsKey(input[0]))
                {
                    shopInfo[input[0]] = new Dictionary<string, double>();
                }
                if (shopInfo.ContainsKey(input[0]))
                {
                    shopInfo[input[0]][input[1]] = double.Parse(input[2]); 
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var store in shopInfo)
            {
                Console.WriteLine(store.Key + "->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
