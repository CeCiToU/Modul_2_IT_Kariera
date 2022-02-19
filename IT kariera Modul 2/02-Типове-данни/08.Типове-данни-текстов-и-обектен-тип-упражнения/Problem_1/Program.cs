using System;

namespace ConsoleApp92
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lasrName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName } {lasrName }. You are {age} years old.");

        }
    }
}
