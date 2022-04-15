using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp248
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hoursAndMinutes = Console.ReadLine().Split(' ', ':').ToList();
            var hmInDict = new SortedDictionary<string, List<string>>();
            for(int i = 0; i<hoursAndMinutes.Count - 1; i = i + 2)
            {
                try
                {
                    hmInDict.Add(hoursAndMinutes[i], new List<string>());
                    hmInDict[hoursAndMinutes[i]].Add(hoursAndMinutes[i + 1]);
                }
                catch
                {
                    hmInDict[hoursAndMinutes[i]].Add(hoursAndMinutes[i + 1]);
                }
            }
            string printed = "";
            foreach (var hm in hmInDict)
            {
                hm.Value.Sort();
                for (int i = 0; i < hm.Value.Count; i++)
                {
                    hm.Value.OrderBy(x => x);
                    printed += $"{hm.Key}:{hm.Value[i]}, ";
                }
            }
            int lastComma = printed.LastIndexOf(",");
            printed = printed.Remove(lastComma);
            Console.WriteLine(printed);
        }
    }
}
