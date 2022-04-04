using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp232
{
    class Program
    {
        static void Main(string[] args)
        {
            string ban = Console.ReadLine();
            var text = new StringBuilder(Console.ReadLine());
            string banItem = new string('*', ban.Length);
            text.Replace(ban, banItem);
            Console.WriteLine(text);
            

        }
    }
}
