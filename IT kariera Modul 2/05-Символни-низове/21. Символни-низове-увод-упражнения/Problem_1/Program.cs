using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp211
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int system = commands[0];
            int number = commands[1];
            int result = 0;
            List<int> arr = result.ToString().Split("").Select(int.Parse).ToList();
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {

                    string test = system.ToString();
                    if (arr[j].ToString() == test)
                    {
                        arr[j] = 0;
                        try
                        {
                            arr[j + 1]++;
                        }
                        catch
                        {
                            arr.Add(1);
                        }
                    }
                }
                arr[0]++;
            }
            arr.Reverse();
            Console.WriteLine(string.Join("", arr));
        }
        
    }
}