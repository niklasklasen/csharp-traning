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
                Console.WriteLine("Enter a grade or 'q' to quit ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        var grade = double.Parse(input);
                        book.AddGrade(grade);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("**");
                    }
                }
            }

            var stats = book.GetStatistics();
            
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The avrage is {stats.Average:N1}");
            System.Console.WriteLine($"The lowest is {stats.Low}");
            Console.WriteLine($"The highest is {stats.High}");
            Console.WriteLine($"The letter is {stats.letter}");
        }
    }
}