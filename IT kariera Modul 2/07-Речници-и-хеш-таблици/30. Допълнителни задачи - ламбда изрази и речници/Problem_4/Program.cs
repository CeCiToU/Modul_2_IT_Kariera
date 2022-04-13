using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp257
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var nameWithEmail = new Dictionary<string, string>();
            while(checkForStop)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    checkForStop = false;
                }
                else
                {
                    string email = Console.ReadLine().ToLower();
                    int indexOfUS = email.LastIndexOf("us");
                    int indexOfUK = email.LastIndexOf("uk");
                    if (indexOfUK == -1 && indexOfUS == -1)
                    {
                        nameWithEmail.Add(name, email);
                    }
                }
            }
            foreach(var name in nameWithEmail)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
