using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp207
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string state1 = Console.ReadLine();
            string state2 = Console.ReadLine();
            if (word == "int")
            {
                int max = MaxInt(int.Parse(state1), int.Parse(state2));
                Console.WriteLine(max);
            }
            else if (word == "char")
            {
                char max = MaxChar(char.Parse(state1), char.Parse(state2));
                Console.WriteLine(max);
            }
            else if (word == "string")
            {
                string max = MaxString(state1, state2);
                Console.WriteLine(max);
            }

        }
        static int MaxInt(int num, int num1)
        {
            int max = 0;
            if (num1< num)
            {
                max = num;
            }
            else
            {
                max = num1;
            }
            return max;
        }
        static char MaxChar(char letter, char letter1)
        {
            char max = 'a';
            if (letter < letter1)
            {
                max = letter1;
            }
            else
            {
                max = letter;
            }
            return max;
        }
        static string MaxString(string word, string word1)
        {
            string max = "";
            if (word.Length < word1.Length)
            {
                max = word1;
            }
            else
            {
                max = word;
            }
            return max;
        }
        
    }
}
