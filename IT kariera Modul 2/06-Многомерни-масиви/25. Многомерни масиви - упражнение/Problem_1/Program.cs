using System;

namespace ConsoleApp235
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            arr = FillArray(arr, row, col);
            PrintArray(arr, row, col);


        }

        private static void PrintArray(int[,] arr, int row, int col)
        {
           for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] FillArray(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
    }
}
