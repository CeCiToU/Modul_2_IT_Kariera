using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp259
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForStop = true;
            var nameWithSoccer = new Dictionary<string, int>();
            while(checkForStop)
            {
                string[] arrWithName = Console.ReadLine().Split(": ").ToArray();
                if (arrWithName[0] == "JOKER")
                {
                    checkForStop = false;
                }
                else
                {
                    //има проблеми с .Distinct
                    //трябва да се дооправи
                    string[] cards = arrWithName[1].Split(", ").Distinct().ToArray();
                    int points = CalculatePoints(cards);
                    if (!nameWithSoccer.ContainsKey(arrWithName[0]))
                    {
                        nameWithSoccer.Add(arrWithName[0], points);
                    }
                    else
                    {
                        nameWithSoccer[arrWithName[0]] += points;
                    }
                }
            }
            foreach(var name in nameWithSoccer)
            {
                Console.WriteLine($"{name.Key}: {name.Value}");
            }
        }

        private static int CalculatePoints(string[] cards)
        {
            int points = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                char[] firstCard = cards[i].ToCharArray();
                int num = 0;
                int type = 0;
                if (firstCard[0] == 'A')
                {
                    num = 14;
                    type = Type(firstCard[1]);
                    points += num * type;
                }
                else if (firstCard[0] == 'J')
                {
                    num = 11;
                    type = Type(firstCard[1]);
                    points += num * type;
                }
                else if (firstCard[0] == 'Q')
                {
                    num = 12;
                    type = Type(firstCard[1]);
                    points += num * type;
                }
                else if (firstCard[0] == 'K')
                {
                    num = 13;
                    type = Type(firstCard[1]);
                    points += num * type;
                }
                else if (firstCard[0] == '1' && firstCard[1] == '0')
                {
                    num = 10;
                    type = Type(firstCard[2]);
                    points += num * type;
                }
                else
                {
                    num = int.Parse(firstCard[0].ToString());
                    type = Type(firstCard[1]);
                    points += num * type;
                }

            }
            
            return points;
        }

        private static int Type(char v)
        {
            int num = 0;
            if (v == 'S')
            {
                num = 4;
            }
            else if (v == 'H')
            {
                num = 3;
            }
            else if (v == 'D')
            {
                num = 2;
            }
            else if (v == 'C')
            {
                num = 1;
            }
            return num;
        }
    }
}
