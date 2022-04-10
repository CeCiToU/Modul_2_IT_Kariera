using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp240
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = new Dictionary<string, int>();
            string[] arr = Console.ReadLine().ToLower().Split().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!times.ContainsKey(arr[i]))
                {
                    times.Add(arr[i], 1);
                }
                else
                {
                    times[arr[i]] += 1;
                }

            }
            List<string> forPrinting = new List<string>();
            foreach (var key in times)
            {
                if (key.Value % 2 != 0)
                {
                    forPrinting.Add(key.Key);
                }
            }
            Console.WriteLine(string.Join(", ", forPrinting));
        }
    }
}
