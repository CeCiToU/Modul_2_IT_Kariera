using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp230
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            string text = "That type is string";
            List<string> parameters = Console.ReadLine().Split().ToList();
            string editedText = EditText(text, parameters);
            Console.WriteLine(editedText);
        }

        private static string EditText(string text, List<string> parameters)
        {
            if (parameters[0] == "Remove")
            {
                int parameter1 = int.Parse(parameters[1]);
                int parameter2 = int.Parse(parameters[2]);
                text = text.Remove(parameter1, parameter2 + 1);
            }
            else if (parameters[0] == "Insert")
            {
                char[] currentText = text.ToCharArray();
                int parameter1 = int.Parse(parameters[1]);
                string parameter2 = parameters[2];

                if (currentText[parameter1] == ' ')
                {
                    text = text.Insert(parameter1, " " + parameter2);
                }
                else
                {
                    text = text.Insert(parameter1, parameter2 + " ");
                }


            }
            else if (parameters[0] == "Replace")
            {
                string parameter1 = parameters[1];
                string parameter2 = parameters[2];
                text = text.Replace(parameter1, parameter2);
            }

            return text;
        }
    } 
}
