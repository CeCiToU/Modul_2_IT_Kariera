using System;
using System.Linq;

namespace ConsoleApp255
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            ConvertToOdd(arr);
        }

        private static void ConvertToOdd(int[] arr)
        {
            int num = (int)arr.Average();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= num)
                {
                    arr[i] -= 1;
                }
                else
                {
                    arr[i] += 1;
                }
            }
            PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
