using System;

namespace ConsoleApp222
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string unicode = "";
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }
        }
    }
}
