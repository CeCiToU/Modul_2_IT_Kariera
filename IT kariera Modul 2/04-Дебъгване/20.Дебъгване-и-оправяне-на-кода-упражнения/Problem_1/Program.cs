using System;

namespace ConsoleApp208
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenNum = EvenNums(number);
            int oddNum = OddNums(number);
            Console.WriteLine(evenNum * oddNum);
        }
        static int EvenNums(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
                number /= 10;
            }
            return sum;
        }
        static int OddNums(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 != 0)
                {
                    sum += currentNum;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
