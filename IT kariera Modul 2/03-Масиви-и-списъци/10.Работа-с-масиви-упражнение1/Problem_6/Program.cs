using System;
using System.Linq;

namespace Reversed_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ").ToArray();
            Array.Reverse(strings);
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }
            
        }
    }
}
