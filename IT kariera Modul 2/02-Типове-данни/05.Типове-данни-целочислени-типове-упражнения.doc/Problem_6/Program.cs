using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbersCount; i++ )
            {
                int currentNumberOne = int.Parse(Console.ReadLine());
                int currentNumberTwo = int.Parse(Console.ReadLine());
                int result = currentNumberOne % currentNumberTwo;
                sum += result;
            }
            Console.WriteLine(sum);
        }
    }
}
