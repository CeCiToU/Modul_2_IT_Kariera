using System;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (1 <= number && number <= 20)
            {
                string word = ""; 
               
                for (int i = 0; i < number; i++)
                {
                    char letter = char.Parse(Console.ReadLine());
                    if ('a' <= letter && letter <= 'z' || 'A' <= letter && letter <= 'Z')
                    {
                        word += letter;
                    }
                    
                }
                Console.WriteLine("The word is " + word);
            }
            
        }
    }
}
