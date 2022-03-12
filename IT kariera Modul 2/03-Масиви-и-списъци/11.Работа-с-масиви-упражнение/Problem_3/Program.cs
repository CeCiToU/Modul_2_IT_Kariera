using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp150
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> result = new List<int>() { 1 };
            for (int i = 1; i < n; i++)
            {
                result.Add(result.Skip(Math.Max(0, result.Count() - k)).Sum());
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
