using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp227
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkAgain = true;
            string map = Console.ReadLine();
            string[] key = Console.ReadLine().Split(' ').ToArray();
            while (checkAgain)
            { 
                char symbol =char.Parse( key[0]);
                int number = int.Parse(key[1].ToString());
                string keyWord = new string(symbol, number);
                char[] charArr = map.ToCharArray();
                int index = map.IndexOf(keyWord);
                int counter = 0;
                try
                {
                    for (int i = index; i < charArr.Length; i++)
                    {
                        if (charArr[i] == symbol)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"Hideout found at index {index} and it is with size {counter}!");
                    checkAgain = false;
                }
                catch
                {
                    Array.Clear(key, 0, key.Length);
                    key = Console.ReadLine().Split().ToArray();
                }



                // Console.WriteLine(keyWord);
            }
        }
    }
}
