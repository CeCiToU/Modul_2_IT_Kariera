using System;

namespace ConsoleApp108
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine().ToLower();
            byte n = byte.Parse(Console.ReadLine());
            if (1 <= n && n <= 20)
            {
                string used = "";
                string notUsed = "";
                if (evenOrOdd == "even")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            string notUsedLetters = Console.ReadLine();
                            
                        }
                        else if (i % 2 == 1)
                        {
                            string usedLetters = Console.ReadLine();
                            used += usedLetters + symbol;
                        }
                    }
                    Console.WriteLine(used);
                }
                else if (evenOrOdd == "odd")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            string notUsedLetters = Console.ReadLine();
                            used += notUsedLetters + symbol;
                        }
                        else if (i % 2 == 1)
                        {
                            string usedLetters = Console.ReadLine();
                            
                        }
                    }
                    Console.WriteLine(used);
                }
            }

        }
    }
}
