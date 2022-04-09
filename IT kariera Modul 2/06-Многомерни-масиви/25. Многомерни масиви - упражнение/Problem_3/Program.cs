using System;
using System.Linq;

namespace ConsoleApp238
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            arr = FillArray(arr, row, col);
            Console.WriteLine();
            TakeMinAndPrint(arr, row, col);


        }

        private static void TakeMinAndPrint(int[,] arr, int row, int col)
        {
            int[] min = new int[col];
            for(int i = 0; i < col; i++)
            {
                int checkMin = int.MaxValue;
                for (int j = 0; j < row; j++)
                {
                    
                    if (arr[j, i] < checkMin)
                    {
                        checkMin = arr[j, i];
                    }
                    if (j == row - 1)
                    {
                        min[i] = checkMin;
                    }
                }
            }
            //Print
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(" ", min));
        }

        static int[,] FillArray(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                int[] rowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rowArray[j];
                }
            }
            return arr;
        }
    }
}
