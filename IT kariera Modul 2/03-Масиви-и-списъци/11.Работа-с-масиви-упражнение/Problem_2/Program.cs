using System;
using System.Linq;

namespace ConsoleApp157
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            bool name = true;
            while (name)
            {
                string[] command = new string[3];
                command = Console.ReadLine().Split(" ").ToArray();
                int n = 0;
                if (command[0] == "END")
                {
                    name = false;
                }
                if (command[0] == "Replace")
                {
                    n = int.Parse(command[1]);
                }
                if (command[0] == "Distinct" || command[0] == "Reverse" || command[0] == "Replace" && n >= 0 && n - 1 <= arr.Length)
                {
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
                    else if (command[0] == "Replace")
                    {
                        n = n - 1;
                        arr[n] = command[2];
                    }
                    arr = arr.Where(x => x != " ").ToArray();
                    Console.WriteLine(string.Join(", ", arr));
                }
                else if (command[0] != "END")
                {
                    Console.WriteLine("Invalid input!\n Try - END or try again!");
                }

            } 


        }


    }

}
