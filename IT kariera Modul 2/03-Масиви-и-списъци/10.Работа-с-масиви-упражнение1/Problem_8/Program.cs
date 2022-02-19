using System.Linq;
using System;
using System.Text;

namespace Fold_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayBeforFolding = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            int k = arrayBeforFolding.Length / 4;
            int[] foldingArray = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                foldingArray[i] = arrayBeforFolding[k - 1 - i];
                foldingArray[k + i] = arrayBeforFolding[4 * k - 1 - i];
            }
            int[] arrayAfterFolding = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                arrayAfterFolding[i] = arrayBeforFolding[i + k];
                Console.Write($"{foldingArray[i] + arrayAfterFolding[i]} ");
            }
            Console.WriteLine();
        }
    }
}
