using System;
using System.Collections.Generic;
using System.Linq;

class SimpleCalculator
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Stack<string> expression = new Stack<string>(input.Reverse());

        while (expression.Count > 1)
        {
            int leftOperand = int.Parse(expression.Pop());
            string operation = expression.Pop();
            int rightOperand = int.Parse(expression.Pop());

            if (operation == "+")
            {
                expression.Push((leftOperand + rightOperand).ToString());
            }
            else
            {
                expression.Push((leftOperand - rightOperand).ToString());
            }
        }
        Console.WriteLine(expression.Peek());
    }
     
}

