using System;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            if (1 <=  number && number <= 20 )
            {
                int totalSum = 0;
                for (int i = 0; i < number; i++ )
                {
                    char letter = char.Parse(Console.ReadLine());
                    if ('a' <= letter && letter <= 'z' || 'A' <= letter && letter <= 'Z')
                    {
                        totalSum += (int)(letter);
                    }
                }
                Console.WriteLine("The sum equals: " + totalSum);
            }
        }
    }
}
