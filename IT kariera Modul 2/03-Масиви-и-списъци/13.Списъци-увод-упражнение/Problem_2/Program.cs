using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp170
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i ++)
            {
                Console.WriteLine($"nums[{i}] = {numbers[i]}");
            }
        }
    }
}
