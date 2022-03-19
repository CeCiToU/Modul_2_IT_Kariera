using System;
using System.Linq;

namespace ConsoleApp164
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
