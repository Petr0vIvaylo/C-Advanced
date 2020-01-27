using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> reservationList =
                new Dictionary<string, HashSet<string>>();

            reservationList["VIP"] = new HashSet<string>();
            reservationList["regular"] = new HashSet<string>();

            string guest = Console.ReadLine();

            while (guest != "PARTY")
            {
                if (char.IsDigit(guest[0]))
                {
                    reservationList["VIP"].Add(guest);
                }
                else
                {
                    reservationList["regular"].Add(guest);
                }
                guest = Console.ReadLine();
            }

            while (guest != "END")
            {
                if (reservationList["VIP"].Contains(guest))
                {
                    reservationList["VIP"].Remove(guest);
                }
                else if (reservationList["regular"].Contains(guest))
                {
                    reservationList["regular"].Remove(guest);
                }
                guest = Console.ReadLine();
            }
            int missingGuestsCount = reservationList["VIP"].Count + reservationList["regular"].Count;

            Console.WriteLine(missingGuestsCount);
            foreach (var name in reservationList)
            {
                if (name.Value.Count == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(string.Join('\n', name.Value));
                }
                
            }
        }
    }
}
