using System;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int ID = int.Parse(Console.ReadLine());
            int uniqueNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("First name: " + firstName );
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender );
            Console.WriteLine("Personal ID: " + ID );
            Console.WriteLine("Unique Employee number: " + uniqueNumber);
        }
    }
}
