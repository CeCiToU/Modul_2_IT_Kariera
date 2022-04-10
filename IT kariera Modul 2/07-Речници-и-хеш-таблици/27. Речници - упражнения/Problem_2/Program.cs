using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp241
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var list = new Dictionary<string, string>();
            while (checkForStop)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                if (data[0] == "A")
                {
                    list.Add(data[1], data[2]);
                }
                else if (data[0] == "S")
                {

                    if (list.ContainsKey(data[1]))
                    {
                        Console.WriteLine($"{data[1]} -> {list[data[1]]}");

                    }
                    else
                    {
                        Console.WriteLine($"Contact {data[1]} does not exist.");
                    }
                }
                else if (data[0] == "END")
                {
                    checkForStop = false;
                }
            }


        }

    }
}
