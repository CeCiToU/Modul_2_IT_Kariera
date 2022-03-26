using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp199
{
    class Program
    {
        static void Main(string[] args)
        {
            printHeader();
            printBody();
            printFooter();
        }
        static void printHeader()
        {
            Console.WriteLine("CASH RECIEPT\n------------------------------");
            return;
        }
        static void printBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void printFooter()
        {
            Console.WriteLine("------------------------------\n© BG");
        }
    }
}
