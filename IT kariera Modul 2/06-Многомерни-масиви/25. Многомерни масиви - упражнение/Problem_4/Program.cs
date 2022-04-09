using System;
using System.Linq;

namespace ConsoleApp238
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] arr = new int[rowAndCol[0], rowAndCol[1]];
            arr = FillArray(arr, rowAndCol);
            Console.WriteLine();
            int[] mainDiagonal = new int[rowAndCol[0]];
            int[] secondDiagonal = new int[rowAndCol[0]];
            Console.WriteLine(string.Join(" ", mainDiagonal));
            mainDiagonal = PrintMainDiagonal(arr, rowAndCol, mainDiagonal);
            //PrintArray(arr, rowAndCol);
            /*
             for (int i = 0; i <rowAndCol[0]; i++)
            {
                bool skip = true;
                for (int j = rowAndCol[0]; j > 0 ; j--)
                {
                    skip = false;
                    Console.WriteLine(arr[i, j]);
                    if (skip = false)
                    {
                        break;
                    }
                    
                }
            */
        }

        static int[] PrintMainDiagonal(int[,] arr, int[] rowAndCol, int[] main)
        {
            for(int i = 0; i < rowAndCol[0]; i++)
            {
                main[i] = arr[i, i];
            }
                return main;
            }

        static void PrintArray(int[,] arr, int[] rowAndCol)
        {
            for (int i = 0; i < rowAndCol[0]; i++)
            {
                for (int j = 0; j < rowAndCol[1]; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        static int[,] FillArray(int[,] arr, int[] rowAndCol)
        {
            for (int i = 0; i < rowAndCol[0]; i++)
            {
                int[] rowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < rowAndCol[1]; j++)
                {
                    arr[i, j] = rowArray[j];
                }
            }
            return arr;
        }
    }
}
