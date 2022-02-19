using System;

namespace ConsoleApp101
{
    class Program
    {
        static void Main(string[] args)
        {
            string impSystem = Console.ReadLine().ToLower();
            double number = double.Parse(Console.ReadLine());
            if (impSystem == "miles")
            {
                double kilometers = number * 1.6;
                Console.WriteLine($"{number} {impSystem} = {kilometers:F2} kilometers");
            }
            else if (impSystem == "inches")
            {
                double centimeters = number * 2.54;
                Console.WriteLine($"{number} {impSystem} = {centimeters:F2} centimeters");
            }
            else if (impSystem == "feet")
            {
                double centimeters = number * 30;
                Console.WriteLine($"{number} {impSystem} = {centimeters:F2} centimeters");
            }
            else if (impSystem == "yards")
            {
                double meters = number * 0.91;
                Console.WriteLine($"{number} {impSystem} = {meters:F2} meters");
            }
            else if (impSystem == "gallons")
            {
                double liters = number * 3.8;
                Console.WriteLine($"{number} {impSystem} = {liters:F2} liters");
            }
        }
    }
}
