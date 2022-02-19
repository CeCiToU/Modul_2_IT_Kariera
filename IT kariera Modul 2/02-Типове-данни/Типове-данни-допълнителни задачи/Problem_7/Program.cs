using System;

namespace ConsoleApp104
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
                    if (max < 0)
                    {
                        double years = Math.Ceiling(1.00 * max / -128);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
                    else if (max > 0)
                    {
                        double years = Math.Ceiling(1.00 * max / 127);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
                   
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
                    if (max < 0)
                    {
                        double years = Math.Ceiling(1.00 * max / -128);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
                    else if (max > 0)
                    {
                        double years = Math.Ceiling(1.00 * max / 127);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
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
                    if (max < 0)
                    {
                        double years = Math.Ceiling(1.00 * max / -128);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
                    else if (max > 0)
                    {
                        double years = Math.Ceiling(1.00 * max / 127);
                        if (years == 0)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to 1 year");
                        }
                        else if (years == 1)
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} year");
                        }
                        else
                        {
                            Console.WriteLine($"Prisoner with id {max} is sentenced to {years} years");
                        }
                    }
                }
            }
        }
    }
}
