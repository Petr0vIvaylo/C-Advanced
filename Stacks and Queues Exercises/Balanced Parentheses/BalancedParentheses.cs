using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] openParens = new char[] { '(', '[', '{' };
            char[] closingParens = new char[] { ')', ']', '}' };

            Stack<char> openParensToMatch = new Stack<char>();
            Queue<char> closingParensToMatch = new Queue<char>();

            if (input == "")
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (openParens.Contains(input[i]))
                {
                    openParensToMatch.Push(input[i]);
                }
                else
                {
                    closingParensToMatch.Enqueue(input[i]);
                }
            }


            if (openParensToMatch.Count != closingParensToMatch.Count)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (openParensToMatch.Peek() == '(' && closingParensToMatch.Peek() == ')')
                {
                    RemoveElementsFromCollections(openParensToMatch, closingParensToMatch);
                    continue;
                }
                if (openParensToMatch.Peek() == '[' && closingParensToMatch.Peek() == ']')
                {
                    RemoveElementsFromCollections(openParensToMatch, closingParensToMatch);
                    continue;
                }
                if (openParensToMatch.Peek() == '{' && closingParensToMatch.Peek() == '}')
                {
                    RemoveElementsFromCollections(openParensToMatch, closingParensToMatch);
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }

        static void RemoveElementsFromCollections(Stack<char> a, Queue<char> b)
        {
            a.Pop();
            b.Dequeue();
        }
    }
}
