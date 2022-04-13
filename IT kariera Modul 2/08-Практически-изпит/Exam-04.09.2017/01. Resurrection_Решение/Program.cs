using System;

namespace ConsoleApp260
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < amount; i++)
            {
                double totalLength = double.Parse(Console.ReadLine());
                double totalWidth = double.Parse(Console.ReadLine());
                double wingLength = double.Parse(Console.ReadLine());
                double totalYears = (totalLength * totalLength) * (totalWidth + (2 * wingLength));
                switch (totalWidth % 1)
                {
                    case 0:
                        {
                            Console.WriteLine($"{totalYears}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"{totalYears:F3}");
                            break;
                        }
                }
                
            }
        }
    }
}
