using System;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            bool txt2 = Convert.ToBoolean(txt);
            if (txt2)
            {
                Console.WriteLine("Yes");
            }
            else 
            Console.WriteLine("No");
        }
    }
}
