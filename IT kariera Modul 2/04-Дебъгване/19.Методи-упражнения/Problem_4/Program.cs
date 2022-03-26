using System;

namespace ConsoleApp202
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Pows(number, index));
        }
        static double Pows(int number, int index)
        {
            int res = 1;
            for (int i = 0; i < index; i++)
            {
                res *= number;
            }
            return res;
        }
    }
}
