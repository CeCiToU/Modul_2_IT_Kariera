using System;
using System.Linq;

namespace ConsoleApp157
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i ++)
            {                                               
                string[] command = new string[3];
                command = Console.ReadLine().Split(" ").ToArray();
                if (command[0] == "Distinct")
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        string test = arr[j];
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (test == arr[k])
                            {
                                arr[k] = " ";
                            }
                        }
                    }
                }
                else if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if ( command[0] == "Replace")
                {
                    int n = int.Parse(command[1]);
                    arr[n] = command[2];
                }
            }
            arr = arr.Where(x => x != " ").ToArray();

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
