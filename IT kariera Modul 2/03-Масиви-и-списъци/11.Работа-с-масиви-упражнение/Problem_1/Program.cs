using System;
using System.Text;
using System.Linq;

namespace ConsoleApp141
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i <= 100; i++)
            {
                string[] command = new string[3];
                command = Console.ReadLine().Split(" ").ToArray();
                string[] copyArr = new string[command.Length];
                if (command[0] == "Distinct")
                {
                    Console.WriteLine(string.Join(", ", arr.Distinct()));
                }
                else if (command[0] == "Reverse")
                {
                    Console.WriteLine(string.Join(", ", arr.Reverse()));
                }
                else if (command[0] == "Replace")
                {
                   
                }
            }
        }
       
    }
}
