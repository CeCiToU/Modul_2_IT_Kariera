using System;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
               double meters = double.Parse(Console.ReadLine());
               double hours = double.Parse(Console.ReadLine());
               double minutes = double.Parse(Console.ReadLine());
               double seconds = double.Parse(Console.ReadLine());
               double kilometers = meters / 1000.0;
               
               double hourToMinutesToSeconds = hours * 3600 + minutes * 60 + seconds;
               double secondsToMinutesToHours = hours + minutes / 60 + seconds / 3600;
            double kilometersPerHour = kilometers / secondsToMinutesToHours;
            double metersPerSeconds = meters / hourToMinutesToSeconds;
               double miles = meters / 1609;
               double milesPerHour = miles / secondsToMinutesToHours;
               Console.WriteLine($"{metersPerSeconds:F6}");
               Console.WriteLine($"{kilometersPerHour:F6}");
               Console.WriteLine($"{milesPerHour:F6}");
               
            

        }
    }
}
