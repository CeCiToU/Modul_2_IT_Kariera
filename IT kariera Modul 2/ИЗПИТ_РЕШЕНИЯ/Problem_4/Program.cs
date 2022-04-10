using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp243
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var team = new Dictionary<string, int>();
            while (checkForStop)
            {
                
                string[] currentName = Console.ReadLine().Split(" - ").ToArray();
                string check = string.Join(" ", currentName);
                if (check == "End of match")
                {
                    checkForStop = false;
                }
                else
                {
                    if (!team.ContainsKey(currentName[0]))
                    {
                        int passes = int.Parse(currentName[1]);
                        team.Add(currentName[0], passes);
                    }
                    else
                    {
                        int num = int.Parse(currentName[1]);
                        team[currentName[0]] += num;

                    }
                }
                
            }
            List<string> final = new List<string>();
            foreach(var name in team)
            {
                final.Add($"{name.Key} has passed {name.Value} passes.");
            }
            final.Sort();
            for (int i = 0; i < final.Count; i++)
            {
                Console.WriteLine(final[i]);
            }

        }
    }
}
