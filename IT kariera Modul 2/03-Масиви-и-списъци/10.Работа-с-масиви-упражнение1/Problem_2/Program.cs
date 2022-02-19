using System;
using System.Linq;
namespace Moda
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();
            var max = (numbers.GroupBy(x => x)
    .Select(x => new { num = x, cnt = x.Count() })
    .OrderByDescending(g => g.cnt)
    .Select(g => g.num).First());

            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.",
    max.Key, max.Count());
        }
    }
}
