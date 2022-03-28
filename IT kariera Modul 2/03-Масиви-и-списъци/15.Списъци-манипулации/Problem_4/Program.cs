using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp193
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 |4 5 6 |  7  8
            List<string> nums = Console.ReadLine().Split("|").ToList();
            List<string> result = new List<string>();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                List<string> currentNums = nums[i].Split(" ").Where(x => x != "").ToList();
                result.AddRange(currentNums);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }

}
