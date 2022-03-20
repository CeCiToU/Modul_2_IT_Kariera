using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp176
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int delNum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                delNum = numbers[i];
            }
            Console.WriteLine();
        }
    }
}
