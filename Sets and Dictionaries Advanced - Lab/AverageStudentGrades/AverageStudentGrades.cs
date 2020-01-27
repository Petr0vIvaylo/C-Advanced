using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int studentGradeCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentGradeCount; i++)
            {
                string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!students.ContainsKey(input[0]))
                {
                    students[input[0]] = new List<double>();
                    students[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    students[input[0]].Add(double.Parse(input[1]));
                }
            }

            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.Write($"{item.Value[i]:f2} ");
                }
                Console.WriteLine( $"(avg: {item.Value.Average():f2})");
            }   
               
        }
    }
}
