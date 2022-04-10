using System;
using System.Collections.Generic;

namespace ConsoleApp242
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            var hole = new Dictionary<string, int>();
            bool checkForStop = true;

            while (checkForStop)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    checkForStop = false;
                }
                else
                {
                    int quantity = int.Parse(Console.ReadLine());

                    if (!hole.ContainsKey(resource))
                    {
                        hole.Add(resource, quantity);
                    }
                    else
                    {
                        foreach (var resources in hole)
                        {
                            if (resources.Key == resource)
                            {

                                hole[resources.Key] += quantity;
                            }
                        }
                    }
                }
               

            }
            foreach(var pair in hole)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
