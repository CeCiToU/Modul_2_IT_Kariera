using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp229
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string check = Console.ReadLine();
            string finalString = ShakeNoShake(text, check);

            Console.WriteLine(finalString);
        }

        private static string ShakeNoShake(string text, string check)
        {
            while (true)
            {
                try
                {
                    string textForCheck = text;
                    int index = text.IndexOf(check);
                    text = text.Remove(index, check.Length);
                    int lastIndex = text.LastIndexOf(check);
                    text = text.Remove(lastIndex, check.Length);
                    if (textForCheck != text)
                    {
                        Console.WriteLine("Shake it.");
                    }
                    int num = check.Length / 2;
                    check = check.Remove(num, 1);
                    if (check == "")
                    {
                        break;
                    }
                }
                catch
                {
                    int num = check.Length / 2;
                    check = check.Remove(num, 1);
                    if (check == "")
                    {
                        Console.WriteLine("No Shake.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No Shake.");
                    }
                    
                   
                }
                

            }
            
            return text;
        }
    }
}
