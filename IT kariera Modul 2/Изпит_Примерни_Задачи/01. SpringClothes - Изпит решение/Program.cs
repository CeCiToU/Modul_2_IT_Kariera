using System;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfClothes = sbyte.Parse(Console.ReadLine());
            if (1 <= numberOfClothes && numberOfClothes <= 100)
            {
                int sum = 0;
                for (int i = 0; i < numberOfClothes; i++)
                {
                    string clothes = Console.ReadLine();
                    if (clothes == "t-shirt")
                    {
                        sum += 20;
                    }
                    else if (clothes == "jeans")
                    {
                        sum += 50;
                    }
                    else if (clothes == "trainers")
                    {
                        sum += 70;
                    }
                    else if (clothes == "jacket")
                    {
                        sum += 60;
                    }
                }
                Console.WriteLine($"{sum:F2}");
            }
        }
    }
}