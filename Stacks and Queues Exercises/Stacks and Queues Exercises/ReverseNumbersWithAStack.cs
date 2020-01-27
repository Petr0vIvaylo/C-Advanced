using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumbersWithAStack
{
    static void Main()
    {
        int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> reversedNumbers = new Stack<int>(numbersArr);

        Console.WriteLine(string.Join(" ",reversedNumbers));
    }
}

