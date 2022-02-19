using System;

namespace ConsoleApp112
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (1 <= n && n <= 100)
            {
                string word = "";
                for (int i = 0; i < n; i++)
                {
                    char letter = char.Parse(Console.ReadLine());
                    int letterToNumber = (int)(letter);
                    int newASCIInumber = letterToNumber - key;
                    char finalLetter = (char)(newASCIInumber);

                }
                Console.WriteLine(word);
            }
        }
    }
}
