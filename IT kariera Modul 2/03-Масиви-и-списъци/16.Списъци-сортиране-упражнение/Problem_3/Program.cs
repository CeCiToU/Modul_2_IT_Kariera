using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp196
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for(int i = 0; i < nums.Count; i++)
            {
                double currentNumber = Math.Sqrt(nums[i]);
                if (currentNumber % 1 != 0)
                {
                    nums[i] = 0;
                }
            }
            nums.Sort();

            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums.Where(x => x != 0)));
        }
    }
}
