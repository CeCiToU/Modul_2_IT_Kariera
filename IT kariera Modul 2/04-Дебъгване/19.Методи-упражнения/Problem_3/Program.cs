using System;

namespace ConsoleApp201
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahreheit = double.Parse(Console.ReadLine());
            double celsius = ConvertFromFahrenheitToCelsius(fahreheit);
            Console.WriteLine($"{celsius:F2}");
        }
        static double ConvertFromFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
            
        }
    }
}
