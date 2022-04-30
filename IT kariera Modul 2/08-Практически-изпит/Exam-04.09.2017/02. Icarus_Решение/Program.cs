using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp266
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int startIndex = int.Parse(Console.ReadLine());
            bool checkForStop = true;
            while(checkForStop)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Supernova")
                {
                    checkForStop = false;
                }
                else if(command[0] == "right")
                {
                   arr = Right(int.Parse(command[1]), arr, startIndex);
                }
                else if(command[0] == "left")
                {
                    arr = Left(int.Parse(command[1]), arr, startIndex);
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        // NOT DONE
        //I don't need to solve it 


        private static List<int> Left(int numbersToLeft, List<int> arr, int startIndex)
        {
            for (int i = startIndex; i < numbersToLeft - startIndex; i--)
            {
                try
                {
                    arr[i] -= 1;
                }
                catch
                {
                    numbersToLeft -= i;
                    i = arr.Count;
                }

            }
            return arr;
        }

        private static List<int> Right(int numbersToRight, List<int> arr, int startIndex)
        {
           for(int i = startIndex; i < numbersToRight; i++)
           {
                try
                {
                    arr[i] -= 1;
                }
                catch
                {
                    numbersToRight -= i;
                    i = 0;
                }
                
           }
            return arr;
        }
    }
}
