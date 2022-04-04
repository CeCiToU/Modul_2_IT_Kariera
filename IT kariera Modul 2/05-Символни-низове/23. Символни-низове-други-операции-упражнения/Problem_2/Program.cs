using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp226
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            string text = Console.ReadLine();
            text = OnlyLetters(text);
            Console.WriteLine(text);
        }

        private static string OnlyLetters(string text)
        {
            char[] word = text.ToCharArray();
            string currentNumber = "";
            string currentReplacement = "";
            string finalWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                finalWord += word[i];

                if ('0' <= word[i] && word[i] <= '9')
                {
                    currentNumber += word[i];

                    try
                    {
                        if ('a' <= word[i + 1] && word[i + 1] <= 'z' || 'A' <= word[i + 1] && word[i + 1] <= 'Z')
                        {

                            currentReplacement += word[i + 1];
                            finalWord = finalWord.Replace(currentNumber, currentReplacement);
                            currentNumber = "";
                            currentReplacement = "";
                        }
                    }
                    catch
                    {
                        return finalWord;
                    }


                }
            }
            return finalWord;
        }
    }
}
