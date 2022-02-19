using System;
using System.Linq;
using System.Text;
namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "g", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string word = Console.ReadLine();
            word = word.ToLower();
            for (string word1 = word; word1 != ""; word1 = word1.Remove(0, 1))
            {
                string search = word1.Substring(0, 1);
                for (int i = 0; i < alphabet.Length; i++)
                {
                    string test = alphabet[i];
                    if (test.Equals(search))
                    {
                        Console.WriteLine($"{search} -> {i}");
                        break;
                    }
                }
            }
        }
    }
}
