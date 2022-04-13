using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp253
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            string text = "In CodeCamp you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!";
            List<string> words = 
                text
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ')
                .Where(x => x != "")
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Select(x => x.ToLower())
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
