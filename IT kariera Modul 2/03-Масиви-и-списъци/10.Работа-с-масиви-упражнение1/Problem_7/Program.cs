using System;
using System.Linq;

namespace Reversed_String
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            int[] rotated1 = new int[nums.Length];
            int[] rotated2 = new int[nums.Length];
            int[] rotated3 = new int[nums.Length];
            int[] rotated4 = new int[nums.Length];
            int[] rotated5 = new int[nums.Length];
            int[] rotated6 = new int[nums.Length];
            int[] rotated7 = new int[nums.Length];
            int[] rotated8 = new int[nums.Length];
            int[] sum = new int[nums.Length];
            if (numOfRotations == 1)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, nums[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, nums[i]);
                }
                // works perfect :)
               
            }
            else if  (numOfRotations == 2)
            {
                // rotations (1)
                    int temp = nums[nums.Length - 1];
                    for (int j = nums.Length - 1; j >= 1; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                      int temp1 = nums[nums.Length - 1];
                      for (int j = nums.Length - 1; j >= 1; j--)
                      {
                          nums[j] = nums[j - 1];
                      }
                      nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }

                // sum 

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
                // works just perfectly :)
            }
           else if (numOfRotations == 3)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
            else if (numOfRotations == 4)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // (4)
                int temp3 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp3;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated4[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i] + rotated4[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated4[{0}] = {1}", i, rotated4[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
            else if (numOfRotations == 5)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // (4)
                int temp3 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp3;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated4[i] = nums[i];
                }
                // (5)
                int temp4 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp4;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated5[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i] + rotated4[i] + rotated5[i];
                }
                // printing

                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated4[{0}] = {1}", i, rotated4[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated5[{0}] = {1}", i, rotated5[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
            else if (numOfRotations == 6)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // (4)
                int temp3 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp3;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated4[i] = nums[i];
                }
                // (5)
                int temp4 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp4;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated5[i] = nums[i];
                }
                // (6)
                int temp5 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp5;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated6[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i] + rotated4[i] + rotated5[i] + rotated6[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated4[{0}] = {1}", i, rotated4[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated5[{0}] = {1}", i, rotated5[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated6[{0}] = {1}", i, rotated6[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
            else if (numOfRotations == 7)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // (4)
                int temp3 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp3;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated4[i] = nums[i];
                }
                // (5)
                int temp4 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp4;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated5[i] = nums[i];
                }
                // (6)
                int temp5 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp5;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated6[i] = nums[i];
                }
                // (7)
                int temp6 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp6;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated7[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i] + rotated4[i] + rotated5[i] + rotated6[i] + rotated7[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated4[{0}] = {1}", i, rotated4[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated5[{0}] = {1}", i, rotated5[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated6[{0}] = {1}", i, rotated6[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated7[{0}] = {1}", i, rotated7[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
            else if (numOfRotations == 8)
            {
                // rotatins (1)
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;

                for (int i = 0; i < nums.Length; i++)
                {
                    rotated1[i] = nums[i];
                }
                // (2)
                int temp1 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp1;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated2[i] = nums[i];
                }
                // (3)
                int temp2 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp2;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated3[i] = nums[i];
                }
                // (4)
                int temp3 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp3;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated4[i] = nums[i];
                }
                // (5)
                int temp4 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp4;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated5[i] = nums[i];
                }
                // (6)
                int temp5 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp5;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated6[i] = nums[i];
                }
                // (7)
                int temp6 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp6;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated7[i] = nums[i];
                }
                // (8)
                int temp7 = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp7;
                for (int i = 0; i < nums.Length; i++)
                {
                    rotated8[i] = nums[i];
                }
                // sum

                for (int i = 0; i < nums.Length; i++)
                {
                    sum[i] = rotated1[i] + rotated2[i] + rotated3[i] + rotated4[i] + rotated5[i] + rotated6[i] + rotated7[i] + rotated8[i];
                }
                // printing
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated1[{0}] = {1}", i, rotated1[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated2[{0}] = {1}", i, rotated2[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated3[{0}] = {1}", i, rotated3[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated4[{0}] = {1}", i, rotated4[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated5[{0}] = {1}", i, rotated5[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated6[{0}] = {1}", i, rotated6[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated7[{0}] = {1}", i, rotated7[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Rotated8[{0}] = {1}", i, rotated8[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine("Sum[{0}] = {1}", i, sum[i]);
                }
            }
        }
    }
}
