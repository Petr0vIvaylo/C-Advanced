using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                if (inputData[0] == "1")
                {
                    string currentText = inputData[1];
                    stack.Push(text);
                    text += currentText;
                }
                else if (inputData[0] == "2")
                {
                    stack.Push(text);
                    text = text.Substring(0, text.Length - (int.Parse(inputData[1])));
                }
                else if (inputData[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(inputData[1]) - 1]);
                }
                else if (inputData[0] == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
