using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp166
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                array.Add(numbers[i]);
            }
            int[] arr = new int[array.Count];

            for (int j = 0; j < array.Count; j++)
            {
                arr[j] = array[j];
            }
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
