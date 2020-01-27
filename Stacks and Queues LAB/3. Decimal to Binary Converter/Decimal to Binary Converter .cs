using System;
using System.Collections.Generic;

namespace _3._Decimal_to_Binary_Converter
{
    class DecimalToBinaryConverter 
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Stack<string> binaryResult = new Stack<string>();

            if (input == 0)
            {
                Console.WriteLine(input);
                return;
            }

            while (input > 0)
            {
                binaryResult.Push((input % 2).ToString());
                input /= 2;
            }
            Console.WriteLine(string.Join("",binaryResult));
        }
    }
}
