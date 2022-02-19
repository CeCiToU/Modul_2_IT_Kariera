using System;

namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
           
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine($"{num3:F28}");
        }
    }
}
