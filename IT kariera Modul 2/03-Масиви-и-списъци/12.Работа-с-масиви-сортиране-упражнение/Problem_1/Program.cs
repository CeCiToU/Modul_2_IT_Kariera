using System;
using System.Linq;

namespace ConsoleApp165
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            int equal = 0;
            int dif1 = 0;
            int dif2 = 0;
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        equal += 1;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        dif1 += 1;
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        dif2 += 1;
                    }
                }
                if (equal == arr2.Length)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));

                    }
                    else
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    
                }
                else if (dif1 > dif2 && dif1 <= arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
                else if (dif1 < dif2 && dif2 <= arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
            else if (arr1.Length < arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        equal += 1;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        dif1 += 1;
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        dif2 += 1;
                    }
                }
                if (equal == arr1.Length)
                {
                    if (arr2.Length > arr1.Length)
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));

                    }
                    else
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                    }

                }
                else if (dif1 > dif2 && dif1 <= arr1.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else if (dif1 < dif2 && dif2 <= arr1.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        equal += 1;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        dif1 += 1;
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        dif2 += 1;
                    }
                }
                if (equal == arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
                else if (dif1 > dif2 && dif1 <= arr1.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else if (dif1 < dif2 && dif2 <= arr1.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
        }

    }
}
