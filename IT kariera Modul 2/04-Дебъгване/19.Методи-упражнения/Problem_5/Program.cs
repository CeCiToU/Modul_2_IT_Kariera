using System;

namespace ConsoleApp203
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(Area(width, height));
        }

        static double Area(double width, double height)
        {

            double area = width * height / 2;
            return area;
        }
    }
}
