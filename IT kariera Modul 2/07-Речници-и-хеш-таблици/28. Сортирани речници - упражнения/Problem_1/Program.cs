using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Игра_на_имена_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();
            var dict = new SortedDictionary<double, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    int num = 1;
                    dict[arr[i]] += num;
                }
            }
            foreach(var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
            

        }
    }
}