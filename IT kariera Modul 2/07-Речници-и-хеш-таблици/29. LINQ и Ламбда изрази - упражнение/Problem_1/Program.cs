using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp251
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>();
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
                sum += nums[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Averge = {sum / num}");
        }
    }
}
