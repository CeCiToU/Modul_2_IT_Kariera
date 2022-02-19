using System;

namespace Centures_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
           int centures = int.Parse(Console.ReadLine());
            double years = centures * 100;
            double days = years * 365.2422;
            double hours = days * 24;
            int minutes = (int)(hours * 60);
            Console.WriteLine($"{centures:F0} centures = {years:F0} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes");
        }
    }
}
