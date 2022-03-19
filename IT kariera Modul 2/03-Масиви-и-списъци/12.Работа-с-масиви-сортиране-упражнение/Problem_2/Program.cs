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
            int number = int.Parse(Console.ReadLine());
            array.Add(number);
            int[] array1 = new int[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                array1[i] = array[i];
            }
            Array.Sort(array1);
            Console.WriteLine(string.Join(" ", array1)); 
        }
    }
}
