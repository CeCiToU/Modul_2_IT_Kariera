using System;
using System.Linq;

namespace ConsoleApp138
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsArr = Console.ReadLine().Split(" ");
            int[] quantityArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double[] priceArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            while (true)
            {
                string[] list = new string[2];
                list = Console.ReadLine().Split(" ");
                
                while (list[0] != "done")
                {
                    for (int i = 0; i < quantityArr.Length; i++)
                    {
                        if (list[0] == productsArr[i])
                        {
                            if (int.Parse(list[1]) <= quantityArr[i])
                            {
                                double sum = int.Parse(list[1]) * priceArr[i];
                                Console.WriteLine($"{productsArr[i]} x {list[1]} costs {sum:F2}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("We do not have enough " + productsArr[i]);
                            }
                           
                        }


                    }
                    break;
                }
                if (list[0] == "done")
                {
                    break;
                }
            }
        }
    }
}
