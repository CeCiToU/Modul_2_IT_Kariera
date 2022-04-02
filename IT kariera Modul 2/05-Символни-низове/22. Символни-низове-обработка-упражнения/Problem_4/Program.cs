using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp224
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Where(x => x != "").ToArray();
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += SumOfArrStrings(arr[i]);
            }
            Console.WriteLine($"{sum:F2}");
        }

        static double SumOfArrStrings(string v)
        {
            char[] word = v.ToCharArray();
            string currentString = "";
            for (int i = 1; i < word.Length - 1; i++)
            {
                currentString += word[i];
            }
            int currentNumber = int.Parse(currentString);
            if ('A' <= word[0] && word[0] <= 'Z')
            {
                currentNumber = currentNumber / (word[0] - 64);
            }
            else if('a' <= word[0] && word[0] <= 'z')
            {
                currentNumber = currentNumber * (word[0] - 96);
            }
            if ('A' <= word.Last() && word.Last() <= 'Z')
            {
                currentNumber = currentNumber - (word.Last() - 64);
            }
            else  if ('a' <= word.Last() && word.Last() <= 'z')
            {
                currentNumber = currentNumber + (word.Last() - 96);
            }

            return currentNumber;
        }
    }
}
