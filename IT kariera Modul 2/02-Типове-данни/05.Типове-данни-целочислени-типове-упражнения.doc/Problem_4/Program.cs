using System;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Befor: ");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
            int changePositions = secondNumber;
            secondNumber = firstNumber;
            firstNumber = changePositions;
            Console.WriteLine("After: ");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
            /* 
             * int firstNumber = int.Parse(Console.ReadLine());
             * int secondNumber = int.Parse(Console.ReadLine());
             * Console.WriteLine("Befor: ");
             * Console.WriteLine("a = " + firstNumber);
             * Console.WriteLine("b = " + secondNumber);
             * Console.WriteLine("After: ");
             * Console.WriteLine("a = " + secondNumber);
             * Console.WriteLine("b = " + firstNumber); 
             */
        }
    }
}
