using System;
using System.Linq;

namespace P08_Condense_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] condensedArray = new int[numbers.Length - 1];
                if (numbers.Length == 1)
                {
                    Console.WriteLine(numbers[0]);
                    return;
                }
                for (int i1 = 0; i1 < numbers.Length - 1; i1++)
                {
                    condensedArray[i1] = numbers[i1] + numbers[i1 + 1];
                }
                numbers = condensedArray;
            }
            Console.WriteLine(numbers[0]);

        }
    }
}