using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp244
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
             var allProducts = new Dictionary<string, List<double>>();
            double mainSum = 0;
            while (checkForStop)
            {
                string[] products = Console.ReadLine().Split().ToArray();
                if (products[0] == "stocked")
                {
                    checkForStop = false;

                }
                else
                {
                    if (!allProducts.ContainsKey(products[0]))
                    {
                        allProducts.Add(products[0], new List<double>());
                        allProducts[products[0]].Add(double.Parse(products[1]));
                        allProducts[products[0]].Add(double.Parse(products[2]));
                    }
                    else
                    {
                        if (allProducts.ContainsKey(products[0]))
                        {
                            double quantity = allProducts[products[0]][1];
                            double currentNum = double.Parse(products[2]);
                            allProducts[products[0]].Clear();
                            allProducts[products[0]].Add(double.Parse(products[1]));
                            allProducts[products[0]].Add( quantity + currentNum);
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            foreach (var product in allProducts)
            {
                double numOne = product.Value[0];
                    double numTwo = product.Value[1];
                double sum = numOne * numTwo;
                Console.WriteLine($"{product.Key}: ${product.Value[0]:F2} * {product.Value[1]} = ${sum:F2}");
                mainSum += sum;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grind Total: ${mainSum:F2}");

        }
    }
}
