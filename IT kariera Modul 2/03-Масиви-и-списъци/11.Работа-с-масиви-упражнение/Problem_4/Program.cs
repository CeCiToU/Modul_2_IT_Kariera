using System;
using System.Text;
using System.Linq;

namespace ConsoleApp146
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (arr.Length - 1 == 0)
            {
                Console.WriteLine("{ " + arr[0] + " }");
            }
            else if (arr.Length % 10 == 1 || arr.Length % 10 == 3 || arr.Length % 10 == 5 || arr.Length % 10 == 7 || arr.Length % 10 == 9)
            {
                Console.Write("{ " + arr[arr.Length/2 -1] + ", " + arr[arr.Length/2] + ", " + arr[arr.Length/2 + 1] + " }");
            }
            else
            {
                Console.Write("{ " + arr[arr.Length / 2 - 1] + ", " + arr[arr.Length / 2] + " }");
            }
        }
    }
}
