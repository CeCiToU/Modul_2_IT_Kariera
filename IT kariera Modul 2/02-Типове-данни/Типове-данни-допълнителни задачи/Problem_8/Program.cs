using System;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber )
            {
                if (0 <= secondNumber && secondNumber <= 127)
                {
                    long sum = firstNumber * 10 + secondNumber * 4;
                    Console.WriteLine(sum);
                }
               
            }
            else if (firstNumber < secondNumber )
            {
                if (0 <= firstNumber && firstNumber <= 127)
                {
                    long sum = firstNumber * 4 + secondNumber * 10;
                    Console.WriteLine(sum);
                }
            }

        }
    }
}
