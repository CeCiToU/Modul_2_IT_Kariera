using System;
using System.Linq;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();
            int maxValue = numbers.Max();
            int minValue = numbers.Min();
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++ )
            {
                sum += numbers[i];
               
            }
            double average = sum / numbers.Length;
            Console.WriteLine("Min = {0}", minValue);
            Console.WriteLine("Max = {0}", maxValue);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine($"Average = {average:F1}");

        }
    }
}
