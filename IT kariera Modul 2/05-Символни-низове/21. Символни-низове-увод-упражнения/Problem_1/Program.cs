using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp211
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            if(arr[0] == 2)
            {
                for (int i = 0; arr[1] > 0; i++)
                {
                    int currentNum = arr[1] % 2;
                    if (currentNum == 0)
                    {
                        result.Add(0);
                    }
                    else
                    {
                        result.Add(1);
                    }
                    arr[1] /= 2;
                }
                
                
            } 
            else if (arr[0] == 3)
            {
                for (int i = 0; arr[1] > 0; i++)
                {
                    int currentNum = arr[1] % 3;
                    result.Add(currentNum);
                    arr[1] /= 3;
                }
            }
            else if (arr[0] == 4)
            {
                
            }
            else if (arr[0] == 5)
            {

            }
            else if (arr[0] == 6)
            {

            }
            else if (arr[0] == 7)
            {

            }
            else if (arr[0] == 8)
            {
                int currentNum = arr[1] % 8;
                result.Add(currentNum);
                arr[1] /= 8;
            }
            else if (arr[0] == 9)
            {

            }
            else if (arr[0] == 10)
            {

            }
            result.Reverse();
            Console.WriteLine(string.Join("",result));
        }
    }
}
