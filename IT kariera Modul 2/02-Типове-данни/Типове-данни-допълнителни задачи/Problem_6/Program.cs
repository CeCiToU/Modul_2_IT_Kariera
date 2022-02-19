using System;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
           
            if (type == "sbyte")
            {
                int number = int.Parse(Console.ReadLine());
                if (1 <= number && number <= 20)
                {
                    int max = int.MinValue;
                    for (int i = 0; i < number; i++)
                    {

                        int id = int.Parse(Console.ReadLine());
                        if (-9223372036854775808 <= id && id <= 9223372036854775807)
                        {
                            if (-128 < id && id < 127)
                            {

                                if (max < id)
                                {
                                    max = id;
                                }

                            }
                        }
                        
                        
                    }
                    Console.WriteLine(max);
                }
               
            }
           
            else if (type == "int")
            {
                int number = int.Parse(Console.ReadLine());
                if (1 <= number && number <= 20)
                {
                    int max = int.MinValue;
                    for (int i = 0; i < number; i++)
                    {

                        int id = int.Parse(Console.ReadLine());
                        if (-9223372036854775808 <= id && id <= 9223372036854775807)
                        {
                            if (-2147483648 < id && id < 2147483647)
                            {

                                if (max < id)
                                {
                                    max = id;
                                }

                            }
                        }


                    }
                    Console.WriteLine(max);
                }
            }
            else if (type == "long")
            {
                int number = int.Parse(Console.ReadLine());
                if (1 <= number && number <= 20)
                {
                    int max = int.MinValue;
                    for (int i = 0; i < number; i++)
                    {

                        int id = int.Parse(Console.ReadLine());
                        if (-9223372036854775808 <= id && id <= 9223372036854775807)
                        {
                             if (max < id)
                                {
                                    max = id;
                                }

                           
                        }


                    }
                    Console.WriteLine(max);
                }
            }
        }
    }
}
