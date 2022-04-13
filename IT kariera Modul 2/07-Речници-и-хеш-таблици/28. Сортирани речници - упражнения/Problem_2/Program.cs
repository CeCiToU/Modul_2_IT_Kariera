using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp250
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var dict = new SortedDictionary<string, string>();
            while (checkForStop)
            {
                string[] names = Console.ReadLine().Split().ToArray();
                if (names[0] == "END")
                {
                    checkForStop = false;
                }
                try
                {
                    if (!dict.ContainsKey(names[1]))
                    {
                        dict.Add(names[1], names[2]);
                    }
                }
                catch
                {

                }
            }
            PrintListAll(dict);
        }

        private static void PrintListAll(SortedDictionary<string, string> dict)
        {
            foreach (var name in dict)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
