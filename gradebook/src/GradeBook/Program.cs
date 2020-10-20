using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 6, 9 };
            foreach (var number in numbers)
            {
                var result =+ number;
            }
            var sum = numbers[0] + numbers[1] + numbers[2];
            System.Console.WriteLine(sum);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
