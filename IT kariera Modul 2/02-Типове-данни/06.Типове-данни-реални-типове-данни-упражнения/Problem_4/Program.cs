using System;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sideA = decimal.Parse(Console.ReadLine());
            decimal sideB = decimal.Parse(Console.ReadLine());
            decimal perimeter = sideA * 2 + sideB * 2;
            decimal area = sideA * sideB;
            double AC = (double) ( sideA * sideA + sideB * sideB);
            decimal ACsqrt =(decimal) (Math.Sqrt(AC));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine($"{ACsqrt:F13}");
        }
    }
}
