using System;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberHexadecimal = Console.ReadLine();
            int numberDecimal = Convert.ToInt32(numberHexadecimal, 16);
            Console.WriteLine(numberDecimal);
        }
    }
}
