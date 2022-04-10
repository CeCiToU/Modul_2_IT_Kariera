using System;

namespace ConsoleApp246
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < num; i++)
            {
                string product = Console.ReadLine();
                switch(product)
                {
                    case "desk":
                        sum += 1789;
                        break;
                    case "chair":
                        sum += 1699;
                        break;
                    case "computer":
                        sum += 5899;
                        break;
                }
                
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
