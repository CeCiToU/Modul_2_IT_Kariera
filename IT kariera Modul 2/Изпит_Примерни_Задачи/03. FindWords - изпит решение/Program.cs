using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Print(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i == list.Count - 1)
            {
                Console.Write(list[i]);
            }
            else
            {
                Console.Write(list[i] + ", ");
            }
        }
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        List<string> special = new List<string>();
        List<string> other = new List<string>();
        int condition = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
            if ('A' <= arr[i][0] && arr[i][0] <= 'Z')
            {
                condition++;
            }
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == 'i')
                {
                    condition++;
                    break;
                }
            }
            if (arr[i].Length > 7)
            {
                condition++;
            }
            
            if (condition == 3)
            {
                special.Add(arr[i]);
            }
            else
            {
                other.Add(arr[i]);
            }
            condition = 0;
        }
        Console.Write("Special words: ");
        Print(special);
        Console.WriteLine();
        Console.Write("Other words: ");
        Print(other);
        Console.WriteLine();

    }
}