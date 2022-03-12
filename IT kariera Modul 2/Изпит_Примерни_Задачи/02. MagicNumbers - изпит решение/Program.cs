using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp143
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] numbersCopy = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }
            List<string> cow1 = new List<string>();
            List<string> cow2 = new List<string>();
            List<string> cow3 = new List<string>();
            int sumOfAll = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 10 == 4 || numbers[i] % 10 == 8)
                {
                    cow1.Add(numbers[i] + "");
                    while (numbersCopy[i] != 0)
                    {
                        sumOfAll += numbersCopy[i] % 10;
                        numbersCopy[i] = numbersCopy[i] / 10;

                        if (sumOfAll == 15)
                        {
                            cow3.Add(numbers[i] + "");
                            break;
                        }
                    }

                    sumOfAll = 0;
                }
                else if (numbers[i] % 10 == 5 || numbers[i] % 10 == 7)
                {
                    cow2.Add(numbers[i] + "");
                    while (numbersCopy[i] != 0)
                    {
                        sumOfAll += numbersCopy[i] % 10;
                        numbersCopy[i] = numbersCopy[i] / 10;

                        if (sumOfAll == 15)
                        {
                            cow3.Add(numbers[i] + "");
                            break;
                        }
                    }

                    sumOfAll = 0;
                }
                else //sum of all
                {
                    while (numbersCopy[i] != 0)
                    {
                        sumOfAll += numbersCopy[i] % 10;
                        numbersCopy[i] = numbersCopy[i] / 10;

                        if (sumOfAll == 15)
                        {
                            cow3.Add(numbers[i] + "");
                            break;
                        }
                    }

                    sumOfAll = 0;
                }


            }

            Print(cow1);
            Console.WriteLine();
            Print(cow2);
            Console.WriteLine();
            Print(cow3);
        }
        static void Print(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.Write(list[i]);
                }
                else
                {
                    Console.Write(list[i] + ", ");
                }
            }
        }
    }
}
