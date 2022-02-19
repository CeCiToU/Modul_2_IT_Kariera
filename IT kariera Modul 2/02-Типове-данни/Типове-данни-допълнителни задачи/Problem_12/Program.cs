using System;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double biggestVolume = double.MinValue;
                string biggestKeg = "";
            string beerName = "";
            for (int i = 0; i < number; i ++ )
            {
                if (1 <= number && number <= 10)
                {
                    beerName = Console.ReadLine();
                    double radius = double.Parse(Console.ReadLine());
                    if (1 <= radius && radius <= 3.402823E+38)
                    {
                        int height = int.Parse(Console.ReadLine());
                        if (1 <= height && height <= 2147483647)
                        {
                            double volume = Math.PI * radius * radius * height;
                            if (volume > biggestVolume)
                            {
                                biggestVolume = volume;
                                biggestKeg = beerName;
                            }
                        }

                    }
                }
               
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
