using System;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int max = int.MaxValue;
                int min = int.MinValue;
                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            else if ( type == "uint")
            {
                uint max = uint.MaxValue;
                uint min = uint.MinValue;
                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            else if (type == "long")
            {
                long max = long.MaxValue;
                long min = long.MinValue;
                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            else if (type == "byte")
            {
                byte max = byte.MaxValue;
                byte min = byte.MinValue;
                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            else if (type == "sbyte")
            {
                sbyte max = sbyte.MaxValue;
                sbyte min = sbyte.MinValue;
                Console.WriteLine(max);
                Console.WriteLine(min);


            }

        }
    }
}
