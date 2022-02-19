using System;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // 3
            for (char i = 'a'; i < 97 + number; i++)
            {
                for (char l = 'a'; l < 97 + number; l++)
                {
                    for (char u = 'a'; u < 97 + number; u++)
                    {
                        Console.WriteLine($"{i}{l}{u}");
                    }
                }
            }
        }
    }
}
