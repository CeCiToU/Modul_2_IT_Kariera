using System;
using System.Linq;

namespace ConsoleApp137
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
                string list = Console.ReadLine();
                 while (list != "done")
                 {
                        for(int i = 0; i <quantityArr.Length; i++)
                        {
                            if (list == productsArr[i])
                            {
                               Console.WriteLine(productsArr[i] + " costs: " + priceArr[i] + "; Available quantity: " + quantityArr[i]);
                               break;
                            }
                    

                        }
                    break;
                 }
               if (list == "done")
               {
                    break;
               }
            }
            

        }
    }
}
