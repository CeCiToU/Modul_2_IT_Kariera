using System;
using System.Collections.Generic;

namespace ConsoleApp190
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            List<string> special = new List<string>();
            List<string> other = new List<string>();
            int br = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                if (arr[i][0] >= 'A' && arr[i][0] <= 'Z')
                {
                    br++;
                }
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 'i')
                    {
                        br++;
                        break;
                    }
                }
                if (arr[i].Length > 7)
                {
                    br += 1;
                }
                if (br == 3)
                {
                    special.Add(arr[i]);
                }
                else
                {
                    other.Add(arr[i]);
                }
                br = 0;
            }
            Console.Write("Special words: ");
            for (int i = 0; i < special.Count; i++)
            {
                if (i == special.Count - 1)
                {
                    Console.Write(special[i]);
                }
                else
                {
                    Console.Write(special[i] + ", ");
                }
            }
            Console.WriteLine();
            Console.Write("Other words: ");
            for (int i = 0; i < other.Count; i++)
            {
                if (i == other.Count - 1)
                {
                    Console.Write(other[i]);
                }
                else
                {
                    Console.Write(other[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
