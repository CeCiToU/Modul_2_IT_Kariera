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
            //това не трябва обаче не знам как да подредя листа
            //00:00 06:04 02:59 10:33 11:22 06:01
            //06:04 минутите на това и
            //06:01 минутите на това са в един лист
            //и не ги подрежда по ненайни причини
            //иначе всичко останало работи :)
            //hmInDict.OrderBy(x => x.Key).ThenBy(x => x.Value);
            string printed = "";
            foreach (var hm in hmInDict)
            {
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
