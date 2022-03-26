using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp204
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

        }
        static string PrintMax(string type, string state1, string state2)
        {
            int maxNum = 0;
            char maxChar = ' ';
            string maxString = "";
            if (type == "int")
            {
                int num1 = int.Parse(state1);
                int num2 = int.Parse(state2);
                maxNum = Math.Max(num1, num2);
                return maxNum.ToString();
            }
            else if (type == "char")
            {
                char char1 = char.Parse(state1);
                char char2 = char.Parse(state2);
                if (char1 < char2)
                {
                    maxChar = char2;
                }
                else
                {
                    maxChar = char1;
                }
                
                return maxChar.ToString();
            }
            else if (type == "string")
            {
                if (state1.CompareTo(state2) >= 0)
                {
                    maxString = state2;
                    
                }
                else
                {
                    maxString = state1;
                     
                }
                return maxString.ToString();
            }

        }
    }
}
