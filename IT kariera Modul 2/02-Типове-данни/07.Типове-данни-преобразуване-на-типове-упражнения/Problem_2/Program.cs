using System;
using System.Linq;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           
            for (int i = 0; i <= number; i++)
            {
                int digitSum = calcDigitsSum(i);
              if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    Console.WriteLine(i + " -> True");
                }
              else
                {
                      Console.WriteLine(i + " -> False");

                }
                
            }
            
        }
        private static int calcDigitsSum(int num )
            
        {
            int sum = 0;
            while (num != 0)
            {
               
                sum += num % 10;
                num = num / 10;
            }
            
            
            return sum;
        }

    }
}
