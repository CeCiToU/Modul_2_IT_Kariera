using System;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1 = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num1; i++)
            {
                decimal num2 = decimal.Parse(Console.ReadLine());
                sum += num2;
            }
           
          
            Console.WriteLine(sum);
        }
    }
}
