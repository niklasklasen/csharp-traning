using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Niklas Grade Book");
            book.AddGrade(89.1);
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The avrage is {stats.Average:N1}");
            System.Console.WriteLine($"The lowest is {stats.Low}");
            Console.WriteLine($"The highest is {stats.High}");
            Console.WriteLine($"The letter is {stats.letter}");
        }
    }
}