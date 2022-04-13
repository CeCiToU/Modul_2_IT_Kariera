using System;
using System.Collections.Generic;

namespace ConsoleApp256
{
    class Program
    {
        static void Main(string[] args)
        {
            int immuneStrength = int.Parse(Console.ReadLine());
            bool checkForStop = true;
            var virusNames = new Dictionary<string, int>();
            while (checkForStop)
            {
                string virusName = Console.ReadLine();
                int virusNameLength = virusName.Length;
                if (virusName == "end")
                {
                    checkForStop = false;
                    Console.WriteLine($"Final Health: {immuneStrength}");
                }
                else
                {

                    int virusStrength = CalculateVirusStrength(virusName);

                    int timeToStopVirus = 0;
                    if (virusNames.ContainsKey(virusName))
                    {
                        bool contains = true;
                        timeToStopVirus = CalculateTimoToStopVirus(virusStrength, virusNameLength, contains);
                    }
                    else
                    {
                        timeToStopVirus = CalculateTimoToStopVirus(virusStrength, virusNameLength);
                    }
                    if (!virusNames.ContainsKey(virusName))
                    {
                        virusNames.Add(virusName, virusStrength);
                    }

                    var timeSpan = TimeSpan.FromSeconds(timeToStopVirus);
                    immuneStrength = immuneStrength - timeToStopVirus;
                    int mm = timeSpan.Minutes;
                    int ss = timeSpan.Seconds;
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToStopVirus} seconds");
                    Console.WriteLine($"{virusName} defeated in {mm}m {ss}s.");
                    //this isn't done. 
                    // to do
                    Console.WriteLine($"Remaining health: {immuneStrength}");
                }
            }
        }

        private static int CalculateTimoToStopVirus(int virusStrength, int virusNameLength, bool bol = false)
        {
            int time = virusStrength;
            if (bol == false)
            {
                time *= virusNameLength;
            }
            else
            {
                time *= virusNameLength;
                time /= 3;
            }
            return time;
        }

        private static int CalculateVirusStrength(string virusName)
        {
            int sum = 0;
            char[] virus = virusName.ToCharArray();
            for (int i = 0; i < virus.Length; i++)
            {
                sum += virus[i];
            }
            return sum / 3;
        }
    }
}
