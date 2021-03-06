using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp221
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split().ToArray();
            var baseNum = int.Parse(inputNums[0]);
            var numsToConvert = BigInteger.Parse(inputNums[1]);

            var sum = new BigInteger();
            var counter = 0;
            while (numsToConvert != 0)
            {
                var lastDigit = numsToConvert % 10;
                var num = BigInteger.Multiply(lastDigit, BigInteger.Pow(baseNum, counter));
                sum += num;
                numsToConvert /= 10;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }
}
