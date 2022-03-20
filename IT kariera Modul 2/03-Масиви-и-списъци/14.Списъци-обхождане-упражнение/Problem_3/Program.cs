using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp175
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int nMax = numbers.Max();
            int nMin = numbers.Min();
            List<int> n = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == nMax)
                {
                    n.Add(numbers[i]);
                }
                else if ( numbers[i] == nMin)
                {
                    n.Add(numbers[i]);
                }
            }
            int[] arr = new int[n.Count];
            for (int j = 0; j < n.Count; j ++)
            {
                arr[j] = n[j];
            }
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
            
        }
    }
}
