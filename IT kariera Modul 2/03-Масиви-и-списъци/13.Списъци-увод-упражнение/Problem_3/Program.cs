using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp171
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Console.WriteLine(string.Join("; ", names));
        }
    }
}
