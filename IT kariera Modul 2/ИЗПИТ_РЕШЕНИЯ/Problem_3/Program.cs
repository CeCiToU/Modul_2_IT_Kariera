using System;
using System.Collections.Generic;

namespace ConsoleApp245
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var namesWithSoccer = new Dictionary<string, int>();

            while (checkForStop)
            {
                
                
                string name = Console.ReadLine();
                if (name == "END OF GAME")
                {
                    checkForStop = false;
                }
                else
                {
                    char[] names = name.ToCharArray();
                    int currentResult = 0;
                    if (names[names.Length - 1] == 'a')
                    {
                        currentResult += 10;
                    }
                    else if (names[names.Length - 1] == 'v')
                    {
                        currentResult += 13;
                    }
                    if (names.Length >= 7)
                    {
                        currentResult += 33;
                    }
                    else
                    {
                        currentResult += 22;
                    }
                    if (!namesWithSoccer.ContainsKey(name))
                    {
                        namesWithSoccer.Add(name ,currentResult);
                    }

                }
                

            }
            PrintNameWithMaxPoints(namesWithSoccer);
            
        }

        private static void PrintNameWithMaxPoints(Dictionary<string, int> namesWithSoccer)
        {
            List<int> results = new List<int>();
            foreach(var name in namesWithSoccer)
            {
                results.Add(name.Value);
            }
            int maxRes = int.MinValue;
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] > maxRes )
                {
                    maxRes = results[i];
                }
            }
            foreach (var name in namesWithSoccer)
            {
                if (name.Value == maxRes )
                {
                    Console.WriteLine($"Winner is name: {name.Key}");
                    Console.WriteLine($"Points: {maxRes}");
                }
            }
        }
    }
}
