using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> carNumbers = new HashSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    carNumbers.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    carNumbers.Remove(input[1]);
                }

                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count() == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join('\n', carNumbers));
            }
            
        }
    }
}
