using System;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            if (n <= 20 && n >= 1)
            {
                short capacity = 255;
                int currentCappacity = capacity;
                for (int i = 0; i < n; i++)
                {

                    int litters = int.Parse(Console.ReadLine());
                    if (litters <= 1000 && litters >= 0)
                    {
                        if (currentCappacity - litters >= 0)
                        {
                            currentCappacity -= litters;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient capacity!");
                        }
                    }

                }
                int filled = capacity - currentCappacity;
                Console.WriteLine(filled);
            }
            
        }
    }
}
