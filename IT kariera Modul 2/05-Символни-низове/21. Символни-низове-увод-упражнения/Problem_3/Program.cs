using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp216
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversed = "";
            char[] charArray = word.ToCharArray();
            
            for (int i = charArray.Length - 1; i >= 0 ; i--)
            {
                reversed += charArray[i];
            }
            
            Console.WriteLine(reversed);
        }
    }
}
