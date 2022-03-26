using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp198
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCollection = Console.ReadLine().Split(" ").ToList();

            myCollection.Sort();
            foreach (var name in myCollection.Distinct())
            {
                Console.WriteLine(name + " -> " + myCollection.Count(x => x == name));
            }
        }
    }
}
