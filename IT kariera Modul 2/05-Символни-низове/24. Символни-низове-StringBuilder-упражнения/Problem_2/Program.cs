using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp231
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@').ToArray();
            char[] firstHalf =email[0].ToCharArray();
            char[] secondHalf = email[1].ToCharArray();
            int decide = CheckIfHeLikeHer(firstHalf, secondHalf);
            if (decide < 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else
            {
                Console.WriteLine("Call her!");
            }
        }

        private static int CheckIfHeLikeHer(char[] firstHalf, char[] secondHalf)
        {
            int sumFirstHalf = 0;
            int sumSecondHalf = 0;
            foreach(var txt in firstHalf)
            {
                sumFirstHalf += txt;
            }
            foreach (var txt in secondHalf)
            {
                sumSecondHalf += txt;
            }
            int sumOfAll = sumFirstHalf - sumSecondHalf;
            return sumOfAll;
        }
    }
}
