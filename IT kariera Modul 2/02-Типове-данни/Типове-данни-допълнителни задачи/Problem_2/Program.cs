using System;

namespace ConsoleApp99
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number % 1 == 0)
            {
                if (-9223372036854775808 < number && number < 9223372036854775807)
                {
                    Console.WriteLine("integer");
                }
            }
            else
            {
                if (-9223372036854775808 < number && number < 9223372036854775807)
                {
                    Console.WriteLine("floating-point");
                }
            }
        }
    }
}
