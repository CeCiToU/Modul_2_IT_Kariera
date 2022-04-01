using System;

namespace ConsoleApp215
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInput();
            Console.WriteLine(TopAndBottomRow(number));
            Console.WriteLine(MiddleRow(number));
            Console.WriteLine(TopAndBottomRow(number));
        }
        static int ReadInput()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static string TopAndBottomRow(int number)
        {
            string row = "";
            for (int i = 0; i < number * 2; i++)
            {
                row += "-";
            }
            return row;
        }
        static string MiddleRow(int number)
        { 
        string row = "";
            

            for (int i = 0; i < number / 2; i++)
            {
                    row += "-";
                    for (int j = 0; j< number - 1; j++)
                    {
                        row += "\\/";
                    }
                    row += "-";
                if (i < number / 2 - 1)
                {
                    row += "\n";
                }
            }
            
            return row;
        }
    }
}
