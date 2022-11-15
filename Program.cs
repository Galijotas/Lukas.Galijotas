using System;
using System.IO;

namespace Lukas.Galijotas 
{
    internal class Program
    {

        static void printText(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                int count = 1;
                while (text[i] == text[i + 1])
                {
                    i++;
                    count++;
                    if ((i + 1) == text.Length)
                    {
                        break;
                    }
                    
                }
                if (count <= 1)
                {
                    Console.Write(text[i]);
                }
                else
                {
                    Console.Write($"{"{" + count + "" + text[i] + "}"}" + "");
                }
                
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"data.txt");
            printText(text);
        }

    }
}