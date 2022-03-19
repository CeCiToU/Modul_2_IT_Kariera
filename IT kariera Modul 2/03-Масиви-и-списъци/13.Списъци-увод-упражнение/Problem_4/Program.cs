using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp172
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < names.Count; i++)
            {
                string[] ConvertedNames = names[i].Split(" ");
                Console.WriteLine(ConvertedNames[1] + " " + ConvertedNames[0]);
            }
         }
    }
}
