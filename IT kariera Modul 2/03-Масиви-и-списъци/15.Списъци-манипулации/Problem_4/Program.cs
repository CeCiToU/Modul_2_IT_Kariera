using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp179
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split("|").ToList();
            List<string> arr = new List<string>();
            for(int i = array.Count; i > 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i] = array[i][j].Where(array[j] != );
                }
            }
        }

    }
}
