using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp254
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unfoldedArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = unfoldedArr.Length / 4;
            int[] beginning = new int[num];
            List<int> end = new List<int>();
            List<int> top = new List<int>();
            if (unfoldedArr.Length % 2 == 0)
            { 
                for(int i = 0; i < num; i++)
                {
                    beginning[i] = unfoldedArr[i];
                }
                for (int i = unfoldedArr.Length - 1; i >= num * 3; i--)
                {
                    end.Add(unfoldedArr[i]);
                }
                beginning = beginning.Reverse().ToArray();
                for(int i = 0; i < num ; i++)
                {
                    top.Add(beginning[i]);
                }
                for(int i = 0; i < num; i++)
                {
                    top.Add(end[i]);
                }
            }
            int[] bottom = unfoldedArr.Skip(num).Take(num * 2).ToArray();
            int[] result = new int[num * 2];
            for(int i = 0; i < num * 2; i++)
            {
                result[i] = bottom[i] + top[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
