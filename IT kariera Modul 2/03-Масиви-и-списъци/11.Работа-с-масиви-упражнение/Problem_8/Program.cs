using System;
using System.Linq;

namespace ConsoleApp160
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxCount = 0;
            int maxNum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i]) count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = nums[i];
                }
            }
            Console.WriteLine(maxNum);

        }

    }
}
