using System;

namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number % 1 == 0)
            {
                if (number <= 9223372036854775807 && number >= -9223372036854775808)
                {
                    if (number <= 2147483647 && number >= -2147483648)
                    {
                        if (number <= 127 && number >= -128)
                        {
                            Console.WriteLine("Sunny");
                        }
                        else
                        {
                            Console.WriteLine("Cloudy");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Windy");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Rainy");
            }
            
        } 
    }
}
