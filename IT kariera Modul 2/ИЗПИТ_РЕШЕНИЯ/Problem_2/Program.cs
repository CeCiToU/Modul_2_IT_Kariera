using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp247
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> patients = Console.ReadLine().Split(", ").ToList();
            bool checkForStop = true;
            while (checkForStop)
            {

                string command = Console.ReadLine();
                if (command == "END OF PATIENTS")
                {
                    checkForStop = false;
                }
                else
                {
                    switch (command)
                    {
                        case "Add patient":

                                string name = Console.ReadLine();
                                patients.Add(name);

                            break;
                                case "Add patient on position":
                                string names = Console.ReadLine();
                                int num = int.Parse(Console.ReadLine());
                                if (0 <= num && num <= 20)
                                {
                                    patients.Insert(num, names);
                                }
                                break;
                        case "Remove last patient":
                            patients.RemoveAt(patients.Count - 1);
                            break;
                        case "Remove first patient":
                            patients.RemoveAt(0);
                            break;
                        case "Remove patient on position":
                            int nums = int.Parse(Console.ReadLine());
                            if (0 <= nums && nums <= 20)
                            {
                                patients.RemoveAt(nums);
                            }
                            break;

                    }

                }

            }
            Console.WriteLine(string.Join(" ", patients));
        }
    }
}
