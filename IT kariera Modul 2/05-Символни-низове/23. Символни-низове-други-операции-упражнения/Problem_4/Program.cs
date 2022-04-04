using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp228
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine();
            string text = Console.ReadLine();
            string bannedText = BanWords(bannedWord, text);
            Console.WriteLine(bannedText);
        }

        private static string BanWords(string bannedWord, string text)
        {
            
            string ban = new string('*', bannedWord.Length);
            
                text = text.Replace(bannedWord, ban);
            


            return text;
        }
    }
}
