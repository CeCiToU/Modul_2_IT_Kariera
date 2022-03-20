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
         
            delNum = numbers.Last();
            for (int i = 0; i < numbers.Count; i ++)
            {
                if (numbers[i] == delNum )
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
