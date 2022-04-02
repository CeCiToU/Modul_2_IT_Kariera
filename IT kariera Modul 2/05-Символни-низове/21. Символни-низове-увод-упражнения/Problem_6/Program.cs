using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            string word = Console.ReadLine();
            bool check = CheckForPalindrom(word);
            Console.WriteLine(check);
        }

        private static bool CheckForPalindrom(string word)
        {
            string text = word;
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            string reversedText = string.Join("", arr);
            if (text == reversedText)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
