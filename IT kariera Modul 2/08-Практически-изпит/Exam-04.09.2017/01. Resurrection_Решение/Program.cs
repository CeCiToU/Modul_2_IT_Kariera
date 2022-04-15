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
                decimal totalLength = decimal.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                decimal wingLength = decimal.Parse(Console.ReadLine());
                decimal totalYears = (totalLength * totalLength) * (totalWidth + (2 * wingLength));
                switch ((int)totalWidth % 1)
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
