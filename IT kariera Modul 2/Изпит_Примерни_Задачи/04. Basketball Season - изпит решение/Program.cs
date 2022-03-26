using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp192
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> finalNames = new List<string>();
            List<int> finalSoccer = new List<int>();
            int count = 0;
            while (true)
            {
                
                List<string> names = new List<string>();
                List<int> soccerNumbers = new List<int>(names.Count);
                string[] currentName = Console.ReadLine().Split(" - ").ToArray();
                if (currentName[0] == "END")
                {
                    break;
                }
                bool state = false;
                if (finalNames.Count == 0)
                {
                    finalNames.Add(currentName[0]);
                    finalSoccer.Add(int.Parse(currentName[1]));
                }
                for (int i = 0; i < finalNames.Count; i++)
                {
                    if (finalNames[i] == currentName[0])
                    {
                        state = true;
                        
                    }
                }
                if (state == false)
                {
                    finalNames.Add(currentName[0]);
                    finalSoccer.Add(int.Parse(currentName[1]));
                }

                else
                {
                    for (int j = 0; j < finalNames.Count;j++)
                    {
                        if (finalNames[j] == currentName[0] && count != 0)
                        {
                            finalSoccer[j] += int.Parse(currentName[1]);
                        }
                        
                    }
                }

                count++;

            }
            List<string> print = new List<string>();
            for (int h = 0; h < finalNames.Count; h++)
            {
                print.Add(finalNames[h] + " -> " + finalSoccer[h]);
            }
            print.Sort();
            Console.WriteLine();
            for (int i = 0; i < finalNames.Count; i++)
            {
                Console.WriteLine(print[i]);
            }
            
        }
    }
}
