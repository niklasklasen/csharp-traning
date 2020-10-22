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
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"The avrage is {stats.Average:N1}");
            System.Console.WriteLine($"The lowest is {stats.Low}");
            Console.WriteLine($"The highest is {stats.High}");
        }
    }
}