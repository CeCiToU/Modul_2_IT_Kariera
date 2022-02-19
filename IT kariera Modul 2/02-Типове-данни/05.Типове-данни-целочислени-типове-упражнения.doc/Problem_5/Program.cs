using System;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string resultOne = Convert.ToString(number, 16);
            string resultTwo = Convert.ToString(number, 2);
            resultOne = resultOne.ToUpper();
            resultTwo = resultTwo.ToUpper();
            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
        }
    }
}
