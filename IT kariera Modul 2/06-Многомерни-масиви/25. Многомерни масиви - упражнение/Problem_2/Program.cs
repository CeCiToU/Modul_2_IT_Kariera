using System;
using System.Collections.Generic;

namespace ConsoleApp236
{
    class Program
    {


        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            arr = FillArray(arr, row, col);
            CalculateAverageAndPrint(arr, row, col);

        }

        private static void CalculateAverageAndPrint(int[,] arr, int row, int col)
        {
            double sumForTheRow = 0;
            List<double> averageForTheRow = new List<double>();
            for (int i = 0; i < row; i++)
            {
                double average = 0;
                for (int j = 0; j < col; j++)
                {
                    //int currentNumber = arr[i, j];
                    sumForTheRow += arr[i , j];
                }
                average = sumForTheRow / col;
                averageForTheRow.Add(average);
                sumForTheRow  = 0;


            }

            PrintArray(arr, row, col, averageForTheRow);
        }

        private static void PrintArray(int[,] arr, int row, int col, List<double> averageForTheRow)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(averageForTheRow[i]);
            }
            return;
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
