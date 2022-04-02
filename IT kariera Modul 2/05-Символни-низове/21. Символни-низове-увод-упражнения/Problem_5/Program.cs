using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp220
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            string words = Console.ReadLine();
            int result = GetResultFromWords(words);
            Console.WriteLine(result);

        }

        private static int GetResultFromWords(string words)
        {
            string[] text = words.Split().ToArray();
            string firstWord = text[0];
            string secondWord = text[1];

            int sum = 0;
            for (int i = 0; i < MaxWordLength(firstWord, secondWord); i++)
            {
                try
                {
                    sum += firstWord[i] * secondWord[i];
                }
                catch
                {
                    if (MaxWordLength(firstWord, secondWord) > firstWord.Length)
                    {
                        sum += secondWord[i];
                    }
                    else if (MaxWordLength(firstWord, secondWord) > secondWord.Length)
                    {
                        sum += firstWord[i];
                    }
                }

            }

            return sum;
        }

        private static int MaxWordLength(string firstWord, string secondWord)
        {
            if (firstWord.Length > secondWord.Length)
            {
                return firstWord.Length;
            }
            else
            {
                return secondWord.Length;
            }
        }
    }
}
